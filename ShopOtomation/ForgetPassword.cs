using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOtomation
{
    public partial class ForgetPassword : Form
    {
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
    }
}
