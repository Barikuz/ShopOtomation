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

namespace ShopOtomation
{
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {
        string username;
        string password;
        static string connectionString = "Server=localhost;Database=shopotomation;Uid=root;Pwd=190464;"; // For database connection
        string nullErrorsString; // For record error messages if fields on form are empty
        string query;
        static Dictionary<string, object> user = new Dictionary<string, object>();

        public LoginPage()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }



        public static bool checkUserRemembered()
        {
            try
            {
                string query = "SELECT* FROM users WHERE remember_me = 1";
                
                queryOnUsersTable("", "", query, connectionString, user);

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
            nullErrorsString = null;

            if (!IsFieldEmpty(Username, "Kullanıcı adı", ref nullErrorsString) & !IsFieldEmpty(Password, "Şifre", ref nullErrorsString))
            {
                username = Username.Text;
                password = Password.Text;
                query = "SELECT * FROM users WHERE username = @username LIMIT 1";
                queryOnUsersTable(username, "", query,connectionString, user);

                if (user != null && (string)user["user_password"] == password)
                {
                    MessageBox.Show("Giriş başarılı!\nLütfen bekleyiniz...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    switchBetweenPagesWithAnimation(this, new MainPage());
                }
                else
                {
                    MessageBox.Show("Giriş başarısız!\nKullanıcı adı veya şifre hatalı!",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (RemindMe.Checked)
                {
                    query = "UPDATE users SET remember_me = 1 WHERE username = @username LIMIT 1";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@username", username);

                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Hata: " + ex.Message);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show(nullErrorsString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
