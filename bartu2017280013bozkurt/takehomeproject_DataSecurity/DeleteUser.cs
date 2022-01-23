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
    public partial class DeleteUser : Form
    {
        Connection con = new Connection();

        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            { 
                Connection.DataSource();
                con.connOpen();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Delete from tblLogin_Acc Where id = 1";
                sqlCommand.Connection = Connection.connMaster;
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("User Deleted Succesfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DeleteUser_Load(object sender, EventArgs e)
        {

            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Select * from tblLogin_Acc";
                sqlCommand.Connection = Connection.connMaster;
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = sqlCommand;
                dt.Clear();
                da.Fill(dt);
                dataGW.DataSource = dt;

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

        private void btnAddmin_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
