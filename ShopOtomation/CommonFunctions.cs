using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopOtomation
{
    public static class CommonFunctions
    {
        public static string connectionString = "Server=localhost;Database=shopotomation;Uid=root;Pwd=190464;"; // For database connection
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public static string fieldEmptyErrorsString; // For record error messages if fields on form are empty
        public static string query;



        public static void switchBetweenPagesWithAnimation(Form pageToClose,Form pageToOpen)
        {
            pageToOpen.Opacity = 0;
            pageToOpen.Show();

            //Fade-Out and Fade-In Animation
            Timer timer = new Timer();
            timer.Interval = 1; //Makes tick ​​event run every 1ms.
            timer.Tick += (s, args) => //Function to run when tick event occurs.
            {
                if (pageToClose.Opacity > 0) /*Decrease the opacity of the current form and increase the opacity of the opened form 
                                        until current one is completely invisible.*/
                {
                    pageToClose.Opacity -= 0.05;
                    pageToOpen.Opacity += 0.05;
                }
                else //After it's end stop tick event and hide current form.
                {
                    timer.Stop();
                    pageToClose.Hide();
                }
            };

            timer.Start();
        }

        public static bool IsFieldEmpty(Control control, string name,ref string nullErrorsString) // Checks if input fields empty on forms        
        {
            if (control.Text != "")
            {
                return false;
            }
            else
            {
                nullErrorsString += $"{name} alanı boş olamaz\n";
                return true;
            }
        }

        public static void Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Shut down app when we click to close button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); 
            }
        }

        public static void queryOnUsersTable(string username,string password, string query,string connectionString, Dictionary<string, object> user)
        {
            // Prepare for query
            MySqlCommand command = prepareDBCommand(query);

            if (username != "")
                command.Parameters.AddWithValue("@username", username);

            if (password != "")
                command.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = prepareDBReader(command);

            try
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        //Save the user in the user-dictionary if doesn't exist 
                        if (!user.ContainsKey(reader.GetName(i))) //For the avoid forget password queries errors
                            user.Add(reader.GetName(i), reader.GetValue(i));
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                MessageBox.Show("Bir hata meydana geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reader.Close();
            connection.Close();   
        }

        public static MySqlCommand prepareDBCommand(string query)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                return command;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);

                MessageBox.Show("Bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static MySqlDataReader prepareDBReader(MySqlCommand command)
        {
            try
            {
                MySqlDataReader reader = command.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);

                MessageBox.Show("Bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static bool prepareDBNonQuery(MySqlCommand command)
        {
            try
            {
                int result = command.ExecuteNonQuery();

                // Check the result and notify the user
                if (result > 0)
                {
                    MessageBox.Show("İşlem Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("İşlem başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);

                MessageBox.Show("Bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
