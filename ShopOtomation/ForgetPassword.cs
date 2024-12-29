using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ShopOtomation.CommonFunctions;


namespace ShopOtomation
{
    public partial class ForgetPassword : Form
    {
        string username;
        string newPassword;
        string securityQuestionAnswer;
        Dictionary<string, object> user = new Dictionary<string, object>();

        public ForgetPassword()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }


        //Click events
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Close app
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Minimize app
        }

        private void Login_Click(object sender, EventArgs e)
        {
            switchBetweenPagesWithAnimation(this, new LoginPage()); //Redirect to login screen
        }

        private void Register_Click(object sender, EventArgs e)
        {
            switchBetweenPagesWithAnimation(this, new RegisterPage()); //Redirect to register screen
        }

        private void ResetPassword_Click(object sender, EventArgs e)
        {
            fieldEmptyErrorsString = null;

            // Check if the relevant fields are empty and if so fill in the error message string to show to the user later
            if (!IsFieldEmpty(Username, "Kullanıcı adı", ref fieldEmptyErrorsString)
                & !IsFieldEmpty(NewPassword, "Yeni şifre", ref fieldEmptyErrorsString)
                & !IsFieldEmpty(NewPasswordAgain, "Yeni şifre tekrarı", ref fieldEmptyErrorsString)
                & !IsFieldEmpty(SecurityQuestionAnswer, "Güvenlik sorusunun cevabı", ref fieldEmptyErrorsString))
            {
                //Get data about user from form fields
                username = Username.Text;
                newPassword = NewPassword.Text;
                securityQuestionAnswer = SecurityQuestionAnswer.Text;

                query = "SELECT * FROM users WHERE username = @username LIMIT 1";
                queryOnUsersTable(username, "", query, connectionString, user); // Get the correct user if exist

                if (newPassword == NewPasswordAgain.Text) // Check if password matches
                {
                    // Check if the security question answer is correct and if so, reset the password
                    if ((string)user["security_question_answer"] == securityQuestionAnswer)
                    {
                        query = "UPDATE users SET user_password = @password WHERE username = @username";
                        queryOnUsersTable(username, newPassword, query, connectionString, user);

                        MessageBox.Show("Şifre başarıyla yenilendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        switchBetweenPagesWithAnimation(this, new LoginPage()); //Redirect to login screen
                    }
                    else
                    {
                        MessageBox.Show("Güvenlik sorusunun cevabı yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //Show error if passwords don't match
                {
                    MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else // Show error if fields are empty
            {
                MessageBox.Show(fieldEmptyErrorsString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
