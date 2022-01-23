namespace takehomeproject_DataSecurity
{
    partial class DeleteUser
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
            this.dataGW = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAddmin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGW)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGW
            // 
            this.dataGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGW.Location = new System.Drawing.Point(12, 27);
            this.dataGW.Name = "dataGW";
            this.dataGW.Size = new System.Drawing.Size(455, 283);
            this.dataGW.TabIndex = 6;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(115, 344);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAddmin
            // 
            this.btnAddmin.Location = new System.Drawing.Point(196, 344);
            this.btnAddmin.Name = "btnAddmin";
            this.btnAddmin.Size = new System.Drawing.Size(90, 23);
            this.btnAddmin.TabIndex = 7;
            this.btnAddmin.Text = "Back to Admin";
            this.btnAddmin.UseVisualStyleBackColor = true;
            this.btnAddmin.Click += new System.EventHandler(this.btnAddmin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(292, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 406);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddmin);
            this.Controls.Add(this.dataGW);
            this.Controls.Add(this.btnDel);
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteUser";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGW;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAddmin;
        private System.Windows.Forms.Button btnClose;
    }
}