namespace takehomeproject_DataSecurity
{
    partial class AdminPage
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
            this.txtBox_Phone_Admin = new System.Windows.Forms.TextBox();
            this.txtBox_Email_Admin = new System.Windows.Forms.TextBox();
            this.txtBoxAdress_Admin = new System.Windows.Forms.TextBox();
            this.rTxt_Feedback_Admin = new System.Windows.Forms.RichTextBox();
            this.btnClose_Admin = new System.Windows.Forms.Button();
            this.lbl_Feedback_Admin = new System.Windows.Forms.Label();
            this.lbl_Phone_Admin = new System.Windows.Forms.Label();
            this.lbl_Email_Admin = new System.Windows.Forms.Label();
            this.lbl_Adress_Admin = new System.Windows.Forms.Label();
            this.btn_Save_Admin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_List_Admin = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_Phone_Admin
            // 
            this.txtBox_Phone_Admin.Location = new System.Drawing.Point(168, 182);
            this.txtBox_Phone_Admin.MaxLength = 13;
            this.txtBox_Phone_Admin.Name = "txtBox_Phone_Admin";
            this.txtBox_Phone_Admin.Size = new System.Drawing.Size(211, 20);
            this.txtBox_Phone_Admin.TabIndex = 20;
            // 
            // txtBox_Email_Admin
            // 
            this.txtBox_Email_Admin.Location = new System.Drawing.Point(168, 119);
            this.txtBox_Email_Admin.MaxLength = 50;
            this.txtBox_Email_Admin.Name = "txtBox_Email_Admin";
            this.txtBox_Email_Admin.Size = new System.Drawing.Size(211, 20);
            this.txtBox_Email_Admin.TabIndex = 19;
            // 
            // txtBoxAdress_Admin
            // 
            this.txtBoxAdress_Admin.Location = new System.Drawing.Point(168, 56);
            this.txtBoxAdress_Admin.MaxLength = 50;
            this.txtBoxAdress_Admin.Name = "txtBoxAdress_Admin";
            this.txtBoxAdress_Admin.Size = new System.Drawing.Size(211, 20);
            this.txtBoxAdress_Admin.TabIndex = 18;
            // 
            // rTxt_Feedback_Admin
            // 
            this.rTxt_Feedback_Admin.Location = new System.Drawing.Point(168, 241);
            this.rTxt_Feedback_Admin.MaxLength = 1000;
            this.rTxt_Feedback_Admin.Name = "rTxt_Feedback_Admin";
            this.rTxt_Feedback_Admin.Size = new System.Drawing.Size(211, 96);
            this.rTxt_Feedback_Admin.TabIndex = 17;
            this.rTxt_Feedback_Admin.Text = "";
            // 
            // btnClose_Admin
            // 
            this.btnClose_Admin.Location = new System.Drawing.Point(335, 362);
            this.btnClose_Admin.Name = "btnClose_Admin";
            this.btnClose_Admin.Size = new System.Drawing.Size(75, 23);
            this.btnClose_Admin.TabIndex = 16;
            this.btnClose_Admin.Text = "Close";
            this.btnClose_Admin.UseVisualStyleBackColor = true;
            this.btnClose_Admin.Click += new System.EventHandler(this.btnClose_Admin_Click);
            // 
            // lbl_Feedback_Admin
            // 
            this.lbl_Feedback_Admin.AutoSize = true;
            this.lbl_Feedback_Admin.Location = new System.Drawing.Point(75, 266);
            this.lbl_Feedback_Admin.Name = "lbl_Feedback_Admin";
            this.lbl_Feedback_Admin.Size = new System.Drawing.Size(55, 13);
            this.lbl_Feedback_Admin.TabIndex = 15;
            this.lbl_Feedback_Admin.Text = "Feedback";
            // 
            // lbl_Phone_Admin
            // 
            this.lbl_Phone_Admin.AutoSize = true;
            this.lbl_Phone_Admin.Location = new System.Drawing.Point(66, 185);
            this.lbl_Phone_Admin.Name = "lbl_Phone_Admin";
            this.lbl_Phone_Admin.Size = new System.Drawing.Size(78, 13);
            this.lbl_Phone_Admin.TabIndex = 14;
            this.lbl_Phone_Admin.Text = "Phone Number";
            // 
            // lbl_Email_Admin
            // 
            this.lbl_Email_Admin.AutoSize = true;
            this.lbl_Email_Admin.Location = new System.Drawing.Point(75, 119);
            this.lbl_Email_Admin.Name = "lbl_Email_Admin";
            this.lbl_Email_Admin.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email_Admin.TabIndex = 13;
            this.lbl_Email_Admin.Text = "Email";
            // 
            // lbl_Adress_Admin
            // 
            this.lbl_Adress_Admin.AutoSize = true;
            this.lbl_Adress_Admin.Location = new System.Drawing.Point(75, 56);
            this.lbl_Adress_Admin.Name = "lbl_Adress_Admin";
            this.lbl_Adress_Admin.Size = new System.Drawing.Size(39, 13);
            this.lbl_Adress_Admin.TabIndex = 12;
            this.lbl_Adress_Admin.Text = "Adress";
            // 
            // btn_Save_Admin
            // 
            this.btn_Save_Admin.Location = new System.Drawing.Point(254, 362);
            this.btn_Save_Admin.Name = "btn_Save_Admin";
            this.btn_Save_Admin.Size = new System.Drawing.Size(75, 23);
            this.btn_Save_Admin.TabIndex = 21;
            this.btn_Save_Admin.Text = "Update";
            this.btn_Save_Admin.UseVisualStyleBackColor = true;
            this.btn_Save_Admin.Click += new System.EventHandler(this.btn_Save_Admin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Attention : Your Role is Admin so you can update users info and if you want to de" +
    "lete the users.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_List_Admin
            // 
            this.btn_List_Admin.Location = new System.Drawing.Point(168, 362);
            this.btn_List_Admin.Name = "btn_List_Admin";
            this.btn_List_Admin.Size = new System.Drawing.Size(80, 23);
            this.btn_List_Admin.TabIndex = 23;
            this.btn_List_Admin.Text = "List User Info ";
            this.btn_List_Admin.UseVisualStyleBackColor = true;
            this.btn_List_Admin.Click += new System.EventHandler(this.btn_List_Admin_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(79, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 407);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_List_Admin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save_Admin);
            this.Controls.Add(this.txtBox_Phone_Admin);
            this.Controls.Add(this.txtBox_Email_Admin);
            this.Controls.Add(this.txtBoxAdress_Admin);
            this.Controls.Add(this.rTxt_Feedback_Admin);
            this.Controls.Add(this.btnClose_Admin);
            this.Controls.Add(this.lbl_Feedback_Admin);
            this.Controls.Add(this.lbl_Phone_Admin);
            this.Controls.Add(this.lbl_Email_Admin);
            this.Controls.Add(this.lbl_Adress_Admin);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Phone_Admin;
        private System.Windows.Forms.TextBox txtBox_Email_Admin;
        private System.Windows.Forms.TextBox txtBoxAdress_Admin;
        private System.Windows.Forms.RichTextBox rTxt_Feedback_Admin;
        private System.Windows.Forms.Button btnClose_Admin;
        private System.Windows.Forms.Label lbl_Feedback_Admin;
        private System.Windows.Forms.Label lbl_Phone_Admin;
        private System.Windows.Forms.Label lbl_Email_Admin;
        private System.Windows.Forms.Label lbl_Adress_Admin;
        private System.Windows.Forms.Button btn_Save_Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_List_Admin;
        private System.Windows.Forms.Button btnDelete;
    }
}