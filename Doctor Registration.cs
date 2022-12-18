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
    public partial class Doctor_Registration : Form
    {
        DAO db = new DAO();
        doc dd = new doc();
        public Doctor_Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dd.id = textBox1.Text;
            dd.name = textBox2.Text;
            if (radioButton1.Checked == true)
            {
                dd.gen = radioButton1.Text;
            }
            else
            {
                dd.gen = radioButton2.Text;
            }
            dd.age = textBox3.Text;
            dd.qualification = textBox4.Text;
            dd.salary = textBox5.Text;
            dd.cont = textBox6.Text;
            dd.addr = textBox7.Text;
            dd.insertdocdata();
            MessageBox.Show("data inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dd.id = textBox1.Text;
            dataGridView1.DataSource = dd.Searchdata();
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Did = textBox1.Text;
            doc doctor = db.getdoc(Did);
            if (doctor == null)
            {
                MessageBox.Show("No id found");
            }
            else
            {
                textBox2.Text = doctor.name;
                textBox3.Text = doctor.age;
                textBox4.Text = doctor.qualification;
                textBox5.Text = doctor.salary;
                textBox6.Text = doctor.cont;
                textBox7.Text = doctor.addr;

                if (doctor.gen == "Male")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dd.id = textBox1.Text;
            dd.name = textBox2.Text;
            if (radioButton1.Checked == true)
            {
                dd.gen = radioButton1.Text;
            }
            else
            {
                dd.gen = radioButton2.Text;
            }
            dd.age = textBox3.Text;
            dd.qualification = textBox4.Text;
            dd.salary = textBox5.Text;
            dd.cont = textBox6.Text;
            dd.addr = textBox7.Text;
            MessageBox.Show("data updated");

            dd.updatedata();
        }

        private void Doctor_Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

