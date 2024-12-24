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
        string nullErrorsString;
        InputData[] databaseEntries = new InputData[6];

        public RegisterPage()
        {

            InitializeComponent();
            DoubleBuffered = true;

            FillSecurityQuestions();
            CreateDatabaseEntries();

        }

        private void FillSecurityQuestions() // Fills the SecurityQuestion ComboBoxEdit with QuestionItem objects
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

                            string id = reader.GetInt32("id").ToString();
                            string question = reader.GetString("question");

                            SecurityQuestion.Properties.Items.Add(new QuestionItem(id,question));
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void CreateDatabaseEntries()
        {
            databaseEntries[0] = new InputData("username", "Kullanıcı adı", Username);
            databaseEntries[1] = new InputData("user_password", "Parola", Password);
            databaseEntries[2] = new InputData("first_name", "Ad", FirstName);
            databaseEntries[3] = new InputData("surname", "Soyad", Surname);
            databaseEntries[4] = new InputData("security_question_id", "Güvenlik sorusu", SecurityQuestion);
            databaseEntries[5] = new InputData("security_question_answer", "Güvenlik sorusunun cevabı", SecurityQuestionAnswer);
        } // Create data objects and add them to an array for insert data to database later

        private void FillInputDatas()
        {
            foreach (InputData inputData in databaseEntries)
            {
                if (!IsFieldEmpty(inputData.control, inputData.fieldNameOnForm))
                {
                    if (inputData.control is TextBox)
                        inputData.value = inputData.control.Text; // If input field is a TextBox, get Text

                    if (inputData.control is DevExpress.XtraEditors.ComboBoxEdit) // If input field is a DevExpress ComboBoxEdit, get Selected Item id
                    {
                        QuestionItem questionItem = (QuestionItem) SecurityQuestion.SelectedItem;
                        inputData.value = questionItem.id;
                    }
                }
            }
        }

        private void InsertDatabaseEntries()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string baseQuery = "INSERT INTO users ({0}) VALUES ({1})";

                    List<string> columnNames = new List<string>();
                    List<string> values = new List<string>();

                    foreach (InputData inputData in databaseEntries)
                    {
                        columnNames.Add(inputData.columnNameOnDatabase); 
                        values.Add($"@{inputData.columnNameOnDatabase}");
                    }

                    string columns = string.Join(", ", columnNames);
                    string valuePlaceholders = string.Join(", ", values);

                    string query = string.Format(baseQuery, columns, valuePlaceholders);


                    // Komut nesnesini oluşturma
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        foreach (InputData inputData in databaseEntries)
                        {

                            if (inputData.columnNameOnDatabase == "security_question_id")
                            {
                                command.Parameters.AddWithValue($"@{inputData.columnNameOnDatabase}", Convert.ToInt32(inputData.value));
                            }
                            else
                            {
                                command.Parameters.AddWithValue($"@{inputData.columnNameOnDatabase}", inputData.value);

                            }

                        }

                        // Komutu çalıştırma
                        int result = command.ExecuteNonQuery();

                        // Sonuç kontrolü
                        if (result > 0)
                        {
                            MessageBox.Show("Başarıyla kayıt olundu!");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt işlemi başarısız.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
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

        private void Register_Click(object sender, EventArgs e) // Get user inputs and save them
        {
            nullErrorsString = null;

            FillInputDatas();
            
            IsFieldEmpty(PasswordAgain, "Şifre tekrarı");

            if(nullErrorsString != null)
            {
                MessageBox.Show(nullErrorsString);
            }
            else
            {
                if (Password.Text == PasswordAgain.Text)
                {
                    InsertDatabaseEntries();
                }
                else
                {
                    MessageBox.Show("Parolalar eşleşmiyor!");
                }
            }

            
        }
        
        // This checks if input fields empty on RegisterPage form
        private bool IsFieldEmpty(Control control,string name)
        {
            if(control.Text != "")
            {
                return false;
            }
            else
            {
                nullErrorsString += $"{name} alanı boş olamaz\n";
                return true;
            }
        }

    }

    // The class that combines security questions with id
    public class QuestionItem
    {
        public string id;
        public string question;

        public QuestionItem(string id, string question) 
        {
            this.id = id;
            this.question = question;
        }

        public override string ToString()  // This determine what text will show in comboBox
        {
            return question; 
        }
    }

    public class InputData
    {
        public string columnNameOnDatabase;
        public string fieldNameOnForm;
        public string value;
        public Control control; 

        public InputData(string columnNameOnDatabase, string fieldNameOnForm,Control control)
        {
            this.columnNameOnDatabase = columnNameOnDatabase;
            this.control = control;
            this.fieldNameOnForm = fieldNameOnForm;
        }
    }



}
