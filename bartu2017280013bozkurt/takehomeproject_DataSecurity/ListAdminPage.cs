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
    public partial class ListAdminPage : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-1T1MT1U\MSSQLSERVER01;initial catalog=tblLoginAccount;integrated security=True");

        public ListAdminPage()
        {
            InitializeComponent();
        }

        private void btn_back_Userpage_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Hide();
        }

        private void ListAdminPage_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from tbl_userInfo", conn);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    txtBoxAdress_User.Text = dataReader["adress"].ToString();
                    txtBox_Email_User.Text = dataReader["email"].ToString();
                    txtBox_Phone_User.Text = dataReader["phonenumber"].ToString();
                    rTxt_Feedback_User.Text = dataReader["feedback"].ToString();
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            finally
            {
                conn.Close();
            }
        }

        private void btn_Close_ListUser_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
