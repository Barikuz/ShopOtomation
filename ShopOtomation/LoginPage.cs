using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static ShopOtomation.CommonFunctions;
using System.Drawing.Drawing2D;

namespace ShopOtomation
{
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {
        string username;
        string password;
        static Dictionary<string, object> user = new Dictionary<string, object>();



        public LoginPage()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public static bool checkUserRemembered() //To pass the login process
        {
            try
            {
                string query = "SELECT* FROM users WHERE remember_me = 1";

                queryOnUsersTable("", "", query, connectionString, user); //Find the last remembered user if exist

                if (user.Count != 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                MessageBox.Show("Bir hata meydana geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }



        //Click Events
        private void Login_Click(object sender, EventArgs e)
        {
            fieldEmptyErrorsString = null;

            // Check if the relevant fields are empty and if so fill in the error message string to show to the user later
            if (!IsFieldEmpty(Username, "Kullanıcı adı", ref fieldEmptyErrorsString) & !IsFieldEmpty(Password, "Şifre", ref fieldEmptyErrorsString))
            {
                //Get data about user from form fields
                username = Username.Text;
                password = Password.Text;

                query = "SELECT * FROM users WHERE username = @username LIMIT 1";
                queryOnUsersTable(username, "", query,connectionString, user); // Get the correct user if exist

                //Log in if user exists and password is correct
                if (user != null && (string)user["user_password"] == password)
                {
                    MessageBox.Show("Giriş başarılı!\nLütfen bekleyiniz...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    switchBetweenPagesWithAnimation(this, new MainPage());
                }
                //If not don't
                else
                {
                    MessageBox.Show("Giriş başarısız!\nKullanıcı adı veya şifre hatalı!",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //If remember me is checked, save this data to the relevant user in the database
                if (RemindMe.Checked)
                {
                    query = "UPDATE users SET remember_me = 1 WHERE username = @username LIMIT 1";

                    MySqlCommand command = prepareDBCommand(query);
                    
                    try
                    {
                        command.Parameters.AddWithValue("@username", username);

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show(fieldEmptyErrorsString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            switchBetweenPagesWithAnimation(this, new RegisterPage());
        }

        private void ForgetPassword_Click(object sender, EventArgs e)
        {
            switchBetweenPagesWithAnimation(this, new ForgetPassword());
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
