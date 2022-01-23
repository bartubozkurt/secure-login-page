namespace takehomeproject_DataSecurity
{
    partial class ListUserPage
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
            this.txtBox_Phone_User = new System.Windows.Forms.TextBox();
            this.txtBox_Email_User = new System.Windows.Forms.TextBox();
            this.txtBoxAdress_User = new System.Windows.Forms.TextBox();
            this.rTxt_Feedback_User = new System.Windows.Forms.RichTextBox();
            this.lbl_Feedback_User = new System.Windows.Forms.Label();
            this.lbl_Phone_User = new System.Windows.Forms.Label();
            this.lbl_Email_User = new System.Windows.Forms.Label();
            this.lbl_Adress_User = new System.Windows.Forms.Label();
            this.btn_Close_ListUser = new System.Windows.Forms.Button();
            this.btn_back_Userpage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_Phone_User
            // 
            this.txtBox_Phone_User.Location = new System.Drawing.Point(145, 192);
            this.txtBox_Phone_User.Name = "txtBox_Phone_User";
            this.txtBox_Phone_User.ReadOnly = true;
            this.txtBox_Phone_User.Size = new System.Drawing.Size(211, 20);
            this.txtBox_Phone_User.TabIndex = 19;
            // 
            // txtBox_Email_User
            // 
            this.txtBox_Email_User.Location = new System.Drawing.Point(145, 129);
            this.txtBox_Email_User.Name = "txtBox_Email_User";
            this.txtBox_Email_User.ReadOnly = true;
            this.txtBox_Email_User.Size = new System.Drawing.Size(211, 20);
            this.txtBox_Email_User.TabIndex = 18;
            // 
            // txtBoxAdress_User
            // 
            this.txtBoxAdress_User.Location = new System.Drawing.Point(145, 66);
            this.txtBoxAdress_User.Name = "txtBoxAdress_User";
            this.txtBoxAdress_User.ReadOnly = true;
            this.txtBoxAdress_User.Size = new System.Drawing.Size(211, 20);
            this.txtBoxAdress_User.TabIndex = 17;
            // 
            // rTxt_Feedback_User
            // 
            this.rTxt_Feedback_User.Location = new System.Drawing.Point(145, 251);
            this.rTxt_Feedback_User.Name = "rTxt_Feedback_User";
            this.rTxt_Feedback_User.ReadOnly = true;
            this.rTxt_Feedback_User.Size = new System.Drawing.Size(211, 96);
            this.rTxt_Feedback_User.TabIndex = 16;
            this.rTxt_Feedback_User.Text = "";
            // 
            // lbl_Feedback_User
            // 
            this.lbl_Feedback_User.AutoSize = true;
            this.lbl_Feedback_User.Location = new System.Drawing.Point(52, 276);
            this.lbl_Feedback_User.Name = "lbl_Feedback_User";
            this.lbl_Feedback_User.Size = new System.Drawing.Size(55, 13);
            this.lbl_Feedback_User.TabIndex = 15;
            this.lbl_Feedback_User.Text = "Feedback";
            // 
            // lbl_Phone_User
            // 
            this.lbl_Phone_User.AutoSize = true;
            this.lbl_Phone_User.Location = new System.Drawing.Point(43, 195);
            this.lbl_Phone_User.Name = "lbl_Phone_User";
            this.lbl_Phone_User.Size = new System.Drawing.Size(78, 13);
            this.lbl_Phone_User.TabIndex = 14;
            this.lbl_Phone_User.Text = "Phone Number";
            // 
            // lbl_Email_User
            // 
            this.lbl_Email_User.AutoSize = true;
            this.lbl_Email_User.Location = new System.Drawing.Point(52, 129);
            this.lbl_Email_User.Name = "lbl_Email_User";
            this.lbl_Email_User.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email_User.TabIndex = 13;
            this.lbl_Email_User.Text = "Email";
            // 
            // lbl_Adress_User
            // 
            this.lbl_Adress_User.AutoSize = true;
            this.lbl_Adress_User.Location = new System.Drawing.Point(52, 66);
            this.lbl_Adress_User.Name = "lbl_Adress_User";
            this.lbl_Adress_User.Size = new System.Drawing.Size(39, 13);
            this.lbl_Adress_User.TabIndex = 12;
            this.lbl_Adress_User.Text = "Adress";
            // 
            // btn_Close_ListUser
            // 
            this.btn_Close_ListUser.Location = new System.Drawing.Point(281, 377);
            this.btn_Close_ListUser.Name = "btn_Close_ListUser";
            this.btn_Close_ListUser.Size = new System.Drawing.Size(75, 23);
            this.btn_Close_ListUser.TabIndex = 20;
            this.btn_Close_ListUser.Text = "Close";
            this.btn_Close_ListUser.UseVisualStyleBackColor = true;
            this.btn_Close_ListUser.Click += new System.EventHandler(this.btn_Close_ListUser_Click);
            // 
            // btn_back_Userpage
            // 
            this.btn_back_Userpage.Location = new System.Drawing.Point(167, 377);
            this.btn_back_Userpage.Name = "btn_back_Userpage";
            this.btn_back_Userpage.Size = new System.Drawing.Size(108, 23);
            this.btn_back_Userpage.TabIndex = 21;
            this.btn_back_Userpage.Text = "Back to User Page";
            this.btn_back_Userpage.UseVisualStyleBackColor = true;
            this.btn_back_Userpage.Click += new System.EventHandler(this.btn_back_Userpage_Click);
            // 
            // ListUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 410);
            this.Controls.Add(this.btn_back_Userpage);
            this.Controls.Add(this.btn_Close_ListUser);
            this.Controls.Add(this.txtBox_Phone_User);
            this.Controls.Add(this.txtBox_Email_User);
            this.Controls.Add(this.txtBoxAdress_User);
            this.Controls.Add(this.rTxt_Feedback_User);
            this.Controls.Add(this.lbl_Feedback_User);
            this.Controls.Add(this.lbl_Phone_User);
            this.Controls.Add(this.lbl_Email_User);
            this.Controls.Add(this.lbl_Adress_User);
            this.Name = "ListUserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListUserPage";
            this.Load += new System.EventHandler(this.ListUserPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Phone_User;
        private System.Windows.Forms.TextBox txtBox_Email_User;
        private System.Windows.Forms.TextBox txtBoxAdress_User;
        private System.Windows.Forms.RichTextBox rTxt_Feedback_User;
        private System.Windows.Forms.Label lbl_Feedback_User;
        private System.Windows.Forms.Label lbl_Phone_User;
        private System.Windows.Forms.Label lbl_Email_User;
        private System.Windows.Forms.Label lbl_Adress_User;
        private System.Windows.Forms.Button btn_Close_ListUser;
        private System.Windows.Forms.Button btn_back_Userpage;
    }
}