using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_HMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (User.username == txtUserName.Text)
            {
                if (User.property == txtPassword.Text)
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
            else
            {
                MessageBox.Show("you entered wrong ");
            }
            Visible = false;
            
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
