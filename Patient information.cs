using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_HMS
{
    public partial class Patient_information : Form
    {
        DAO dt = new DAO();
        string currentrecord = "";
        public Patient_information()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientinfo ptf = new patientinfo();

            ptf.id = textBox1.Text;
            dataGridView1.DataSource= ptf.search();
            dataGridView1.Refresh();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sid = textBox1.Text;
            currentrecord = sid;

            patientinfo pt = dt.getpatient(sid);

            if (pt == null)
            {
                MessageBox.Show("No id found");
            }
            else
            {
                textBox2.Text = pt.name;
                if (pt.gen == "Male")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                textBox3.Text = pt.age;
                textBox4.Text = pt.date;
                textBox5.Text = pt.cont;
                textBox6.Text = pt.addr;
                textBox7.Text = pt.disease;
                textBox9.Text = pt.r_type;
                textBox10.Text = pt.building;
                textBox11.Text = pt.r_no;
                textBox12.Text = pt.price;



                

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            patientinfo pt = new patientinfo(); // yahan
                        
            if (textBox1.Text == currentrecord)
            {
                pt.id = textBox1.Text;
                pt.name = textBox2.Text;
                if (radioButton1.Checked == true)
                {
                    pt.gen = radioButton1.Text;
                }
                else
                {
                    pt.gen = radioButton2.Text;
                }
                pt.age = textBox3.Text;
                pt.date = textBox4.Text;
                pt.cont = textBox5.Text;
                pt.addr = textBox6.Text;
                pt.disease = textBox7.Text;
                pt.r_type = textBox9.Text;
                pt.building = textBox10.Text;
                pt.r_no = textBox11.Text;
                pt.price = textBox12.Text;
                pt.Update();
                MessageBox.Show("data updated");
            }
          
            else
            {
                MessageBox.Show("Id cant be changed");

            }

        }
    }
}
