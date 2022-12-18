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
    public partial class Staffinformation : Form
    {
        DAO db = new DAO();
        staffinfo s = new staffinfo();
        string currentrecord = "";


        public Staffinformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.id = textBox1.Text;
            s.name = textBox2.Text;
            if (radioButton1.Checked == true)
            {
                s.gen = radioButton1.Text;
            }
            else
            {
                s.gen = radioButton2.Text;
            }
            s.age = textBox3.Text;
            s.position = textBox4.Text;
            s.salary = textBox5.Text;
            s.cont = textBox6.Text;
            s.addr = textBox7.Text;
            s.insertstaffdata();
            MessageBox.Show("data inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staffinfo stf = new staffinfo();

            stf.id = textBox1.Text;
            dataGridView1.DataSource = stf.searchdata();
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string sid = textBox1.Text;

            //DataTable sinfo = db.searchstaff(sid);
            //sinfo.

        }

        private void Staffinformation_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string sid = textBox1.Text;
            currentrecord = sid;

            staffinfo staff = db.getStaff(sid);

            if (staff==null)
            {
                MessageBox.Show("No id found");
            }
            else
            {
                textBox2.Text = staff.name;
                textBox3.Text = staff.age;
                textBox4.Text = staff.position;
                textBox5.Text = staff.salary;
                textBox6.Text = staff.cont;
                textBox7.Text = staff.addr;
                
                if (staff.gen=="Male")
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
            if (textBox1.Text == currentrecord)
            {
                 s.id = textBox1.Text;
                 s.name = textBox2.Text;
                 if (radioButton1.Checked == true)
                 {
                     s.gen = radioButton1.Text;
                 }
                 else
                 {
                     s.gen = radioButton2.Text;
                 }
                 s.age = textBox3.Text;
                 s.position = textBox4.Text;
                 s.salary = textBox5.Text;
                 s.cont = textBox6.Text;
                 s.addr = textBox7.Text;
                 MessageBox.Show("data updated");
                 s.updatedta();
            }
            else
            {
                MessageBox.Show("Id cant be changed");

            }
        }
    }
}
