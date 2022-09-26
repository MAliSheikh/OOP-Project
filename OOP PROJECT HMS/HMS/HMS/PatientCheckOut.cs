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
using System.Data;

namespace HMS
{
    public partial class PatientCheckOut : Form
    {
        public PatientCheckOut()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientCheckout ob = new patientCheckout();
            ob.name = textBox2.Text;
            ob.age = textBox3.Text;
            ob.cont = textBox5.Text;
            ob.addr = textBox6.Text;
            ob.disease = textBox7.Text;
            ob.date = textBox8.Text;
            ob.date_out = textBox9.Text;
            ob.build = textBox10.Text;
            ob.r_no = textBox11.Text;
            ob.r_type = textBox12.Text;
            ob.status = textBox13.Text;
            ob.med_price = textBox14.Text;
            ob.total = textBox15.Text;
            ob.ADD();

        }
        public class patientCheckout : HMS.Form8.patientInformation
        {
            //public string name;
           // public string gen;
           // public string age;
            //public string contact;
           // public string addr;
            public string disease;
            //public string date_in;
            public string date_out;
           public string build;
           // public string r_no;
            //public string r_type;
            public string status;
            public string med_price;
            public string total;


            public void ADD()
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");
                con.Open();
                
               
                try
                {
                    string str = "INSERT INTO checkout1(name,gen,age,contact,addr,disease,date_in,date_out,build,r_no,r_type,status,med_price,total) VALUES('" + name + "','" + gen + "','" + age + "','" + cont  + "','" + addr + "','" + disease + "','" + date + "','" + date_out  + "','" + build + "','" + r_no + "','" + r_type + "','" + status + "','" + med_price + "','" + total + "'); ";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    string str1 = "select max(Id) from checkout1;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Patient Checkout Information Saved Successfully..");
                        name = "";
                        status = "";
                        r_type = "";
                        gen = "";
                        r_no = "";
                        gen = "";
                        total = "";
                        med_price = "";
                        build = "";
                        date_out="";
                        date = "";
                        disease = "";
                        addr = "";
                        age = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
           
            }
        
        }
        private void button2_Click(object sender, EventArgs e)
        {

            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
        }
    }
}
