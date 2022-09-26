using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User ob = new User();
            ob.username = txtUserName.Text;
            ob.pass = txtPassword.Text;
            ob.login();
            this.Hide();
        }
        public class User
        {
            public string username;
            public string pass;

            public void login()
            {
                if (username == "hms" && pass == "pass")
                {
                    MessageBox.Show("login Sucessfully");
                    
                    Home hm = new Home();
                    hm.Show();
                    
                }
                else
                {
                    MessageBox.Show("you entered wrong ");
                }
            
            }
        
        }
    }
}
