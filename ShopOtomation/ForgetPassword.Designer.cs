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
            this.SuspendLayout();
            // 
            // SecurityQuestionAnswer
            // 
            this.SecurityQuestionAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecurityQuestionAnswer.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityQuestionAnswer.Location = new System.Drawing.Point(260, 264);
            this.SecurityQuestionAnswer.Name = "SecurityQuestionAnswer";
            this.SecurityQuestionAnswer.Size = new System.Drawing.Size(320, 24);
            this.SecurityQuestionAnswer.TabIndex = 10;
            // 
            // ResetPassword
            // 
            this.ResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.ResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPassword.FlatAppearance.BorderSize = 0;
            this.ResetPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetPassword.Location = new System.Drawing.Point(345, 359);
            this.ResetPassword.Name = "ResetPassword";
            this.ResetPassword.Size = new System.Drawing.Size(150, 50);
            this.ResetPassword.TabIndex = 14;
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
            this.Close.TabIndex = 15;
            this.Close.UseVisualStyleBackColor = false;
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
            this.Minimize.TabIndex = 16;
            this.Minimize.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.Login.Location = new System.Drawing.Point(377, 430);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(84, 24);
            this.Login.TabIndex = 17;
            this.Login.Text = "Giriş Yap";
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.Register.Location = new System.Drawing.Point(379, 465);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(77, 24);
            this.Register.TabIndex = 18;
            this.Register.Text = "Kayıt Ol";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopOtomation.Properties.Resources.ForgetPassword;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ResetPassword);
            this.Controls.Add(this.SecurityQuestionAnswer);
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
    }
}