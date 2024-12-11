using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShopOtomation
{
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {
        public LoginPage()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
           
            CommonFunctions.switchBetweenPagesWithAnimation(this, new RegisterPage());

        }

        private void ForgetPassword_Click(object sender, EventArgs e)
        {
            CommonFunctions.switchBetweenPagesWithAnimation(this, new ForgetPassword());
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
