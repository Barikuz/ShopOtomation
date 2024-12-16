using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors.Controls;

namespace ShopOtomation
{
    public partial class RegisterPage : Form
    {

        string connectionString = "Server=localhost;Database=shopotomation;Uid=root;Pwd=190464;";
       

        public RegisterPage()
        {

            InitializeComponent();
            DoubleBuffered = true;
            FillSecurityQuestions();

        }

        private void FillSecurityQuestions()
        {
            string query = "SELECT id,question FROM security_questions";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int id = reader.GetInt32("id");
                            string question = reader.GetString("question");

                            SecurityQuestion.Properties.Items.Add(new ImageComboBoxItem(question, id));
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {

            CommonFunctions.switchBetweenPagesWithAnimation(this, new LoginPage());

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Register_Click(object sender, EventArgs e)
        {
           
        }
    }
}
