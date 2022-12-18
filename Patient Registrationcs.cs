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
    public partial class Patient_Registrationcs : Form
    {
        
        public Patient_Registrationcs()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientRegistration PR = new PatientRegistration();
            PR.id = textBox1.Text;
            PR.name = textBox2.Text;
            if (radioButton1.Checked==true)
            {
                PR.gen = radioButton1.Text;
            }
            else
            {
                PR.gen = radioButton2.Text;
            }
            PR.age = textBox3.Text;
            PR.date = textBox4.Text;
            PR.cont = textBox5.Text;
            PR.addr = textBox6.Text;
            PR.disease = textBox7.Text;
            PR.r_type = textBox8.Text;
            PR.building = textBox9.Text;
            PR.r_no = textBox10.Text;
            PR.price =textBox11.Text;
            PR.Register();

            MessageBox.Show("Patient data has inserted!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
