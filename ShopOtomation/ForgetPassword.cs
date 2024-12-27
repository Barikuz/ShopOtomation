using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShopOtomation.CommonFunctions;

namespace ShopOtomation
{
    public partial class ForgetPassword : Form
    {
        string username;
        string newPassword;
        string securityQuestionAnswer;
        string query;
        Dictionary<string, object> user = new Dictionary<string, object>();

        string nullErrorsString; // For record error messages if fields on form are empty
        static string connectionString = "Server=localhost;Database=shopotomation;Uid=root;Pwd=190464;"; // For database connection


        public ForgetPassword()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            CommonFunctions.switchBetweenPagesWithAnimation(this, new RegisterPage());
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

        private void ResetPassword_Click(object sender, EventArgs e)
        {
            nullErrorsString = null;
            
            if (!IsFieldEmpty(Username, "Kullanıcı adı", ref nullErrorsString) 
                & !IsFieldEmpty(NewPassword, "Yeni şifre", ref nullErrorsString)
                & !IsFieldEmpty(NewPasswordAgain, "Yeni şifre tekrarı", ref nullErrorsString)
                & !IsFieldEmpty(SecurityQuestionAnswer, "Güvenlik sorusunun cevabı", ref nullErrorsString))
            {
                username = Username.Text;
                newPassword = NewPassword.Text;
                securityQuestionAnswer = SecurityQuestionAnswer.Text;
                query = "SELECT * FROM users WHERE username = @username LIMIT 1";

                queryOnUsersTable(username, "", query, connectionString, user);

                if(newPassword == NewPasswordAgain.Text)
                {
                    if ((string)user["security_question_answer"] == securityQuestionAnswer)
                    {
                        query = "UPDATE users SET user_password = @password WHERE username = @username";
                        queryOnUsersTable(username, newPassword, query, connectionString, user);

                        MessageBox.Show("Şifre başarıyla yenilendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        switchBetweenPagesWithAnimation(this, new LoginPage());
                    }
                    else
                    {
                        MessageBox.Show("Güvenlik sorusunun cevabı yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(nullErrorsString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
