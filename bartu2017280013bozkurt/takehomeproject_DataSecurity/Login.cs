using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takehomeproject_DataSecurity
{
    public partial class Login : Form
    {
        Connection con = new Connection();
        SelectedItem slct = new SelectedItem();

        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsernameLogin.Text) || string.IsNullOrWhiteSpace(txtBoxPasswordLogin.Text))
            {
                MessageBox.Show("Username or Password is invalid or is to short !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                slct.SelectData(txtBoxUsernameLogin.Text, txtBoxPasswordLogin.Text);
            }

        }
        
    }
}
