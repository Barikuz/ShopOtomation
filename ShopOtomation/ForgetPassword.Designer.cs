namespace ShopOtomation
{
    partial class ForgetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SecurityQuestionAnswer = new System.Windows.Forms.TextBox();
            this.ResetPassword = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.NewPasswordAgain = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SecurityQuestionAnswer
            // 
            this.SecurityQuestionAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecurityQuestionAnswer.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityQuestionAnswer.Location = new System.Drawing.Point(260, 519);
            this.SecurityQuestionAnswer.Name = "SecurityQuestionAnswer";
            this.SecurityQuestionAnswer.Size = new System.Drawing.Size(320, 24);
            this.SecurityQuestionAnswer.TabIndex = 6;
            // 
            // ResetPassword
            // 
            this.ResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.ResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPassword.FlatAppearance.BorderSize = 0;
            this.ResetPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetPassword.Location = new System.Drawing.Point(345, 590);
            this.ResetPassword.Name = "ResetPassword";
            this.ResetPassword.Size = new System.Drawing.Size(150, 50);
            this.ResetPassword.TabIndex = 7;
            this.ResetPassword.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(797, 10);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.TabIndex = 1;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(750, 10);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 32);
            this.Minimize.TabIndex = 2;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.Login.Location = new System.Drawing.Point(377, 660);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(84, 24);
            this.Login.TabIndex = 8;
            this.Login.Text = "Giriş Yap";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.Register.Location = new System.Drawing.Point(379, 693);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(77, 24);
            this.Register.TabIndex = 9;
            this.Register.Text = "Kayıt Ol";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // NewPassword
            // 
            this.NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPassword.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword.Location = new System.Drawing.Point(260, 349);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(320, 24);
            this.NewPassword.TabIndex = 4;
            this.NewPassword.UseSystemPasswordChar = true;
            // 
            // NewPasswordAgain
            // 
            this.NewPasswordAgain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswordAgain.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordAgain.Location = new System.Drawing.Point(260, 434);
            this.NewPasswordAgain.Name = "NewPasswordAgain";
            this.NewPasswordAgain.Size = new System.Drawing.Size(320, 24);
            this.NewPasswordAgain.TabIndex = 5;
            this.NewPasswordAgain.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(260, 264);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(320, 24);
            this.Username.TabIndex = 3;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopOtomation.Properties.Resources.Forget_Password_V3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(840, 760);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.NewPasswordAgain);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ResetPassword);
            this.Controls.Add(this.SecurityQuestionAnswer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SecurityQuestionAnswer;
        private System.Windows.Forms.Button ResetPassword;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox NewPasswordAgain;
        private System.Windows.Forms.TextBox Username;
    }
}