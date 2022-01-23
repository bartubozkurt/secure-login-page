using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace takehomeproject_DataSecurity
{
    class Connection
    {

        public static SqlConnection connMaster;
        public static SqlConnection DataSource()
        {
            connMaster = new SqlConnection(@"data source=DESKTOP-1T1MT1U\MSSQLSERVER01;initial catalog=tblLoginAccount;integrated security=True");
            return connMaster;
        }

        public void connOpen()
        {
            DataSource();
            connMaster.Open();
        }

        public void connClose()
        {
            DataSource();
            connMaster.Close();
        }
    }
}
