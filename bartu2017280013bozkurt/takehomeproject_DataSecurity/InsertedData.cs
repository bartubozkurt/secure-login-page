using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace takehomeproject_DataSecurity
{

    class InsertData
    {
        Connection con = new Connection();
        Encrypt en = new Encrypt();

        public string AddData(string userInsert, string passInsert)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "insert into tblLogin_Acc (username, password) values (@name, @passWord)";


                sqlCommand.Parameters.AddWithValue("@name", userInsert);
                sqlCommand.Parameters.AddWithValue("@passWord", Encrypt.HashString(passInsert));

                sqlCommand.Connection = Connection.connMaster;
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Account Created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.connClose();

                return userInsert + passInsert;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            finally
            {
                con.connClose();
            }
        }

    }
}
