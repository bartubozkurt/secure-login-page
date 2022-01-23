using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace takehomeproject_DataSecurity
{
    public partial class AdminPage : Form
    {

        Connection con = new Connection();

        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnClose_Admin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Save_Admin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxAdress_Admin.Text) || string.IsNullOrWhiteSpace(txtBox_Email_Admin.Text) || string.IsNullOrWhiteSpace(txtBox_Phone_Admin.Text) || string.IsNullOrWhiteSpace(rTxt_Feedback_Admin.Text))
            {
                MessageBox.Show("All fields are required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    Connection.DataSource();
                    con.connOpen();
                    //"insert into tbl_userInfo (adress, email,phonenumber,feedback) values (@adress, @email,@phonenumber,@feedback)"


                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "UPDATE tbl_userInfo SET adress = @add, email = @eMail, phonenumber = @phone, feedback = @feed";
                    sqlCommand.Parameters.AddWithValue("@add", txtBoxAdress_Admin.Text);
                    sqlCommand.Parameters.AddWithValue("@eMail", txtBox_Email_Admin.Text);
                    sqlCommand.Parameters.AddWithValue("@phone", txtBox_Phone_Admin.Text);
                    sqlCommand.Parameters.AddWithValue("@feed", rTxt_Feedback_Admin.Text);

                    sqlCommand.Connection = Connection.connMaster;
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Information Updated Succesfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.connClose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                finally
                {
                    con.connClose();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_List_Admin_Click(object sender, EventArgs e)
        {
            ListAdminPage listAdminPage = new ListAdminPage();
            listAdminPage.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.Show();
            this.Hide();
        }
    }
}
