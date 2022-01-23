namespace takehomeproject_DataSecurity
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxUsernameLogin = new System.Windows.Forms.TextBox();
            this.txtBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(162, 156);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(24, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxUsernameLogin
            // 
            this.txtBoxUsernameLogin.Location = new System.Drawing.Point(94, 47);
            this.txtBoxUsernameLogin.MaxLength = 15;
            this.txtBoxUsernameLogin.Name = "txtBoxUsernameLogin";
            this.txtBoxUsernameLogin.Size = new System.Drawing.Size(159, 20);
            this.txtBoxUsernameLogin.TabIndex = 3;
            // 
            // txtBoxPasswordLogin
            // 
            this.txtBoxPasswordLogin.Location = new System.Drawing.Point(94, 100);
            this.txtBoxPasswordLogin.MaxLength = 15;
            this.txtBoxPasswordLogin.Name = "txtBoxPasswordLogin";
            this.txtBoxPasswordLogin.Size = new System.Drawing.Size(159, 20);
            this.txtBoxPasswordLogin.TabIndex = 4;
            this.txtBoxPasswordLogin.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 252);
            this.Controls.Add(this.txtBoxPasswordLogin);
            this.Controls.Add(this.txtBoxUsernameLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxUsernameLogin;
        private System.Windows.Forms.TextBox txtBoxPasswordLogin;
    }
}

