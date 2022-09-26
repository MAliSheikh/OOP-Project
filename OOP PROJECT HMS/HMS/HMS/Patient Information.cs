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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            display();
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");


        public void display()
        {

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From patient1", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            patientInformation ob = new patientInformation();
            ob.Id = textBox1.Text;
            ob.name = textBox2.Text;
            ob.age = textBox3.Text;
            ob.date = textBox4.Text;
            ob.cont = textBox5.Text;
            ob.addr = textBox6.Text;
            ob.disease = textBox7.Text;
            ob.status = textBox8.Text;
            ob.building = textBox9.Text;
            ob.r_type = textBox10.Text;
            ob.r_no = textBox11.Text;
            ob.price = textBox12.Text;
            ob.Delete();
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientInformation ob = new patientInformation();
            ob.Id = textBox1.Text;
            ob.name = textBox2.Text;
            ob.age = textBox3.Text;
            ob.date = textBox4.Text;
            ob.cont = textBox5.Text;
            ob.addr = textBox6.Text;
            ob.disease = textBox7.Text;
            ob.status = textBox8.Text;
            ob.building = textBox9.Text;
            ob.r_type = textBox10.Text;
            ob.r_no = textBox11.Text;
            ob.price= textBox12.Text;
            ob.search();
            display();

        }
        public class person
        {
            public string Id;
            public string name;
            public string gen;
            public string age;
            public string date;
            public string cont;
            public string addr;
            public string disease;
            public string status;
            public string r_type;
            public string building;
            public string r_no;
            public string price;
        
        }
        public class patientInformation:person
        {


            public patientInformation()
            {

            }
            public patientInformation(string id,string name)
            {
                this.name = name;
                this.Id = id;

                
            }
            public void search( string name)
            {
              
                this.name = name;
                
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");

                con.Open();
                if (Id != "")
                {
                    try
                    {
                        string getCust = "select name,gen,age,date,cont,addr,disease,status,r_type,building,r_no,price from patient1 where name=" + name + " ;";

                        SqlCommand cmd = new SqlCommand(getCust, con);
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            name = dr.GetValue(0).ToString();

                            age = dr.GetValue(2).ToString();
                            date = dr.GetValue(3).ToString();
                            cont = dr.GetValue(4).ToString();
                            addr = dr.GetValue(5).ToString();
                            disease = dr.GetValue(6).ToString();
                            status = dr.GetValue(7).ToString();
                            building = dr.GetValue(8).ToString();
                            r_type = dr.GetValue(9).ToString();
                            r_no = dr.GetValue(10).ToString();
                            price = dr.GetValue(11).ToString();

                        }
                        else
                        {
                            MessageBox.Show(" Sorry, This ID, " + Id + " Staff1 is not Available.   ");
                            Id = "";
                        }
                    }
                    catch (SqlException excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                    con.Close();
                }

            }
          
         
            public void search()
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");

                con.Open();
                if (Id != "")
                {
                    try
                    {
                        string getCust = "select name,gen,age,date,cont,addr,disease,status,r_type,building,r_no,price from patient1 where id=" + Convert.ToInt32(Id) + " ;";

                        SqlCommand cmd = new SqlCommand(getCust, con);
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            name = dr.GetValue(0).ToString();
                            
                         age = dr.GetValue(2).ToString();
                           date = dr.GetValue(3).ToString();
                            cont = dr.GetValue(4).ToString();
                            addr = dr.GetValue(5).ToString();
                            disease = dr.GetValue(6).ToString();
                          status = dr.GetValue(7).ToString();
                            building = dr.GetValue(8).ToString();
                            r_type = dr.GetValue(9).ToString();
                            r_no = dr.GetValue(10).ToString();
                            price = dr.GetValue(11).ToString();

                        }
                        else
                        {
                            MessageBox.Show(" Sorry, This ID, " + Id + " Staff1 is not Available.   ");
                            Id = "";
                        }
                    }
                    catch (SqlException excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                    con.Close();
                }
             
            }
            public void Update()
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");
                con.Open();
             

                try
                {
                    string str = " Update patient1 set name='" + name + "',gen='" + gen + "',age='" + age + "',date='" + date + "',cont='" + cont + "',addr='" + addr  + "',disease='" + disease + "',status='" + status + "',r_type='" + r_type+ "',building='" + building + "',r_no='" + r_no + "',price='" + price + "' where id='" + Id + "'";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();

                    string str1 = "select max(id) from patient1;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("" + name + "'s Details is Updated Successfully.. ", "Important Message");
                        name = "";
                        age = "";
                        date = "";
                        cont = "";
                        addr = "";
                        using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sem.4\C# Projects\Trials\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True"))
                        {

                            string str2 = "SELECT * FROM patient1";
                            SqlCommand cmd2 = new SqlCommand(str2, con1);
                            SqlDataAdapter da = new SqlDataAdapter(cmd2);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                           
                        }
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
            public void Delete()
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");
                con.Open();
                try
                {

                    string str = "DELETE FROM patient1 WHERE id = '" + Id + "'";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" Patient Record Delete Successfully");
                    using (con)
                    {

                        string str2 = "SELECT * FROM patient1";
                        SqlCommand cmd2 = new SqlCommand(str2, con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        
                    }
                    name = "";
                    age = "";
                    date  = "";
                    cont = "";
                   addr = "";
                    disease = "";
                    status = "";
                    r_type = "";
                    building = "";
                    r_no = "";
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please Enter Patient Id..");
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            patientInformation ob = new patientInformation();
            ob.name = textBox2.Text;
            ob.age = textBox3.Text;
            ob.date = textBox4.Text;
            ob.cont = textBox5.Text;
            ob.addr = textBox6.Text;
            ob.disease = textBox7.Text;
            ob.status = textBox8.Text;
            ob.r_type = textBox10.Text;
            ob.building = textBox9.Text;
            ob.r_no = textBox11.Text;
            ob.price = textBox12.Text;
            ob.Id = textBox1.Text;
            ob.Update();
            display();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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

        private void textBox7_TextChanged(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
