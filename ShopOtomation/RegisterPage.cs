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

        string connectionString = "Server=localhost;Database=shopotomation;Uid=root;Pwd=190464;"; // For database connection
        string nullErrorsString; // For record error messages if fields on form are empty
        InputData[] databaseEntries = new InputData[6]; // For data entry into the database



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

                            // It is added together with the id so that the id can be added to the database later.
                            SecurityQuestion.Properties.Items.Add(new QuestionItem(id,question));
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                    MessageBox.Show("Veritabanı tarafında bir sorun oluştu.\nGüvenlik soruları getirilemedi.",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateDatabaseEntries() // Create InputData objects and add them to an array for insert data to database later
        {
            databaseEntries[0] = new InputData("username", "Kullanıcı adı", Username);
            databaseEntries[1] = new InputData("user_password", "Parola", Password);
            databaseEntries[2] = new InputData("first_name", "Ad", FirstName);
            databaseEntries[3] = new InputData("surname", "Soyad", Surname);
            databaseEntries[4] = new InputData("security_question_id", "Güvenlik sorusu", SecurityQuestion);
            databaseEntries[5] = new InputData("security_question_answer", "Güvenlik sorusunun cevabı", SecurityQuestionAnswer);
        }

        private bool IsFieldEmpty(Control control, string name) // Checks if input fields empty on RegisterPage form
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

        private void FillInputDatas() // Takes data from the form fields and fills it into InputData objects
        {
            foreach (InputData inputData in databaseEntries)
            {
                if (!IsFieldEmpty(inputData.control, inputData.fieldNameOnForm)) // Check if the field is empty and prepare the error message
                {
                    if (inputData.control is TextBox)
                        inputData.value = inputData.control.Text; // If input field is a TextBox, get text

                    if (inputData.control is DevExpress.XtraEditors.ComboBoxEdit) // If input field is a DevExpress ComboBoxEdit, get SelectedItem id
                    {
                        QuestionItem questionItem = (QuestionItem) SecurityQuestion.SelectedItem;
                        inputData.value = questionItem.id;
                    }
                }
            }
        } 

        private void InsertDatabaseEntries() // Retrieves data and saves it to database
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // The main query we will fill in later
                    string baseQuery = "INSERT INTO users ({0}) VALUES ({1})";

                    List<string> columnNames = new List<string>();
                    List<string> values = new List<string>();

                    // Get all column names from InputData objects, save them and make placeholders for values section 
                    foreach (InputData inputData in databaseEntries)
                    {
                        columnNames.Add(inputData.columnNameOnDatabase);
                        values.Add($"@{inputData.columnNameOnDatabase}");
                    }

                    string columns = string.Join(", ", columnNames);
                    string valuePlaceholders = string.Join(", ", values);

                    // Fill the main query with column names and placeholders
                    string query = string.Format(baseQuery, columns, valuePlaceholders);


                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Fill the value placeholders in the main query with actual values
                        foreach (InputData inputData in databaseEntries)
                        {
                            // Check column name and make the required type conversion
                            if (inputData.columnNameOnDatabase == "security_question_id")
                            {
                                command.Parameters.AddWithValue($"@{inputData.columnNameOnDatabase}", Convert.ToInt32(inputData.value));
                            }
                            else
                            {
                                command.Parameters.AddWithValue($"@{inputData.columnNameOnDatabase}", inputData.value);
                            }
                        }

                        int result = command.ExecuteNonQuery();

                        // Check the result and notify the user
                        if (result > 0)
                        {
                            MessageBox.Show("Başarıyla kayıt olundu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CommonFunctions.switchBetweenPagesWithAnimation(this, new LoginPage());
                        }
                        else
                        {
                            MessageBox.Show("Kayıt işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                catch (MySqlException ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                    if (ex.Number == 1062) // Duplicate entry (UNIQUE violation)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten alınmış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                    MessageBox.Show("Kayıt işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //Click Events
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
                MessageBox.Show(nullErrorsString,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (Password.Text == PasswordAgain.Text)
                {
                    InsertDatabaseEntries();
                }
                else
                {
                    MessageBox.Show("Parolalar eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

    }

    public class QuestionItem // Class that combines security questions with id
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

    public class InputData // Class that prepares input data for entry into the database
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
