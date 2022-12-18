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
    public partial class patientcheckout : Form
    {
        public patientcheckout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            patientcheckout1 pc = new patientcheckout1();
            pc.id = textBox1.Text;
            pc.name = textBox2.Text;
            if (radioButton1.Checked == true)
            {
                pc.gen = radioButton1.Text;
            }
            else
            {
                pc.gen = radioButton2.Text;
            }
            pc.age = textBox3.Text;
            pc.cont = textBox4.Text;
            pc.addr = textBox5.Text;
            pc.disease = textBox6.Text;
            pc.date_in = textBox7.Text;
            pc.date_out = textBox8.Text;
            pc.build = textBox9.Text;
            pc.r_no = textBox10.Text;
            pc.r_type = textBox11.Text;
            pc.status = textBox12.Text;
            pc.med_price =textBox13.Text;
            pc.total =textBox14.Text;
            pc.insert();
            MessageBox.Show("Patient data has inserted!");
            this.Close();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            patientcheckout1 ptf = new patientcheckout1();

            ptf.id = textBox1.Text;
            dataGridView1.DataSource = ptf.view();
            dataGridView1.Refresh();
        }
    }
}
