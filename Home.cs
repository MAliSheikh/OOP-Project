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

namespace OOP_Project_HMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient_Registrationcs pr = new Patient_Registrationcs();
            pr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult iexit;
            iexit = MessageBox.Show("Confirm you want to exit","OOP Project HMS",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iexit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient_information pf = new Patient_information();
            pf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            patientcheckout pc1 = new patientcheckout();
            pc1.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Staffinformation sti = new Staffinformation();
            sti.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Doctor_Registration dr = new Doctor_Registration();
            dr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
