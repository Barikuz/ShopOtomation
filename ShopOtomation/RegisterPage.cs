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
using static ShopOtomation.CommonFunctions;


namespace ShopOtomation
{
    public partial class RegisterPage : Form
    {
        string fieldEmptyErrorsString; // For record error messages if fields on form are empty
        InputData[] databaseEntries = new InputData[7]; // For data entry into the database
        string query;


        
        public RegisterPage()
        {
            InitializeComponent();
            DoubleBuffered = true;

            query = "SELECT id,question FROM security_questions";
            FillSecurityQuestions(query);

            CreateDatabaseEntries();
        }



        //'Prepare to saving process' functions
        private void FillSecurityQuestions(string query) // Fills the SecurityQuestion ComboBoxEdit with QuestionItem objects
        {

            //Prepare for DB connection
            MySqlCommand command = prepareDBCommand(query);
            MySqlDataReader reader = prepareDBReader(command);

            try
            {
                //Pull data as long as there is data to read
                while (reader.Read())
                {
                    // Get datas from reader
                    string id = reader.GetInt32("id").ToString();
                    string question = reader.GetString("question");

                    // It is added together with the id so that the id can be added to the database later.
                    SecurityQuestion.Properties.Items.Add(new QuestionItem(id, question));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);

                MessageBox.Show("Veritabanı tarafında bir sorun oluştu.\nGüvenlik soruları getirilemedi.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Close everything after finished
            reader.Close();
            connection.Close();
        }

        private void CreateDatabaseEntries() // Create InputData objects and add them to an array for insert data to database later
        {
            databaseEntries[0] = new InputData("first_name", "Ad", FirstName);
            databaseEntries[1] = new InputData("surname", "Soyad", Surname);
            databaseEntries[2] = new InputData("username", "Kullanıcı adı", Username);
            databaseEntries[3] = new InputData("user_password", "Parola", Password);
            databaseEntries[4] = new InputData("user_password", "Parola tekrarı", PasswordAgain);
            databaseEntries[5] = new InputData("security_question_id", "Güvenlik sorusu", SecurityQuestion);
            databaseEntries[6] = new InputData("security_question_answer", "Güvenlik sorusunun cevabı", SecurityQuestionAnswer);
        }



        //Save user to database functions
        private void FillInputDataObjects() // Takes data from the form fields and fills it into InputData objects
        {
            foreach (InputData inputData in databaseEntries)
            {
                if (!IsFieldEmpty(inputData.control, inputData.fieldNameOnForm, ref fieldEmptyErrorsString)) // Check if the field is empty and prepare the error message
                {
                    if (inputData.fieldNameOnForm == "Parola tekrarı") 
                    {
                        continue; //Becase there is no data for save to DB
                    }
                    else
                    {
                        if (inputData.control is TextBox)
                            inputData.value = inputData.control.Text; // If input field is a TextBox, get text

                        if (inputData.control is DevExpress.XtraEditors.ComboBoxEdit) // If input field is a DevExpress ComboBoxEdit, get SelectedItem's id
                        {
                            QuestionItem questionItem = (QuestionItem)SecurityQuestion.SelectedItem;
                            inputData.value = questionItem.id;
                        }
                    }
                }  
            }
        }

        // Prepares query for save new user to users table
        public string PrepareSaveNewUserQuery()
        {
            // The main query we will fill in later
            string baseQuery = "INSERT INTO users ({0}) VALUES ({1})";

            List<string> columnNames = new List<string>();
            List<string> valuesPlaceHolders = new List<string>();

            // Get all column names from InputData objects, save them and make placeholders for values section 
            foreach (InputData inputData in databaseEntries)
            {
                columnNames.Add(inputData.columnNameOnDatabase);
                valuesPlaceHolders.Add($"@{inputData.columnNameOnDatabase}");
            }

            string columns = string.Join(", ", columnNames);
            string valuePlaceholders = string.Join(", ", valuesPlaceHolders);

            // Fill the main query with column names and placeholders
            string query = string.Format(baseQuery, columns, valuePlaceholders);

            return query;
        }

        private void InsertDatabaseEntries() // Retrieves data and saves it to database
        {
            query = PrepareSaveNewUserQuery();
            MySqlCommand command = prepareDBCommand(query);
            
            try
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

                bool isSuccessful = prepareDBNonQuery(command);

                if (isSuccessful)
                {
                    switchBetweenPagesWithAnimation(this, new LoginPage());
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

            connection.Close();
        }



        //Click Events
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            switchBetweenPagesWithAnimation(this, new LoginPage());
        }

        private void Register_Click(object sender, EventArgs e) // Get user inputs and save them
        {
            fieldEmptyErrorsString = null;

            FillInputDataObjects();

            
            if(fieldEmptyErrorsString != null)
            {
                MessageBox.Show(fieldEmptyErrorsString,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error); //Show error messages for empty fields
            }
            else
            {
                if (Password.Text == PasswordAgain.Text)
                {
                    InsertDatabaseEntries(); //Insert datas if passwords matches
                }
                else
                {
                    MessageBox.Show("Parolalar eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); //Show error if not
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
