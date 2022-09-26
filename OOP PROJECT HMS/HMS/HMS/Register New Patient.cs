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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientRegistration ob = new PatientRegistration();
            ob.name = textBox2.Text;
            
            ob.age = textBox3.Text;
            ob.date=textBox4.Text;
            ob.cont = textBox5.Text;
            ob.addr = textBox6.Text;
            ob.disease = textBox7.Text;
            ob.status = textBox8.Text;
            ob.r_type = textBox9.Text;
            ob.building = textBox10.Text;
            ob.r_no = textBox11.Text;
            ob.price = Convert.ToInt32(textBox12.Text);
            ob.Register();

                
            
        }
        public class PatientRegistration
        {
            public string name;
            public string gen;
            public string age;
            public string date;
            public string addr;
            public string cont;
            public string disease;
            public string status;
            public string building;
            public string r_no;
            public string r_type;
            public int price;
            public void PatientBill(int p)
            {
                this.price = p;
            }
            public void Reset()
            {
                name = "";
                gen = "";
                age = "";
                date = "";
                cont = "";
                addr = "";
                disease = "";
                status = "";
                r_no = "";
                r_type = "";
               // price = "";
            }
            public void Register()
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");
                con.Open();
                try
                {
                    string str = "INSERT INTO patient1(name,gen,age,date,cont,addr,disease,status,r_type,building,r_no,price) VALUES('" + name + "','" + gen + "','" + age + "','" + date + "','" + cont + "','" + addr + "','" + disease + "','" + status + "','" + r_type + "','" + building + "','" + r_no + "','" + price + "'); ";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    string str1 = "select max(Id) from patient1;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Patient Information Saved Successfully..");

                        name = "";
                        gen = "";
                        age = "";
                        date = "";
                        cont = "";
                         addr= "";
                        disease = "";
                        status = "";
                        r_no = "";
                       r_type = "";
                     // price = "";

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

            PatientRegistration ob1 = new PatientRegistration();
            ob1.Reset();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
