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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");
  
        
        public void display()
        {
            
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter  adapter = new SqlDataAdapter("Select * From staff1",con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            staffInfo ob = new staffInfo();
            ob.name = textBox2.Text;
            ob.position = textBox4.Text;
            ob.salary = textBox5.Text;
            ob.contact = textBox6.Text;
            ob.address = textBox7.Text;
            ob.Add();
            display();
        }
        public class staffInfo:Person
        {
            public string Id;
            public string name;
            public string gender;
            public string salary;
            public string contact;
            public string address;
          public string position;

            public void Update()
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");
                con.Open();
                string gen = string.Empty;
               
                try
                {
                    string str = " Update staff1 set name='" + name + "',gender='" + gen + "',position='" + position + "',salary='" + salary + "',contact='" + contact + "',address='" + address + "' where id='" + Id + "'";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();

                    string str1 = "select max(id) from staff1;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("" + name + "'s Details is Updated Successfully.. ", "Important Message");
                      name = "";
                        position = "";
                        salary = "";
                        contact = "";
                        address = "";

                    }
                   
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            
            }
            public void search()
            { 
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");

            con.Open();
            if (Id != "")
            {
                try
                {
                    string getCust = "select name,gender,position,salary,contact,address from staff1 where id=" + Convert.ToInt32(Id) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                       Id = dr.GetValue(0).ToString();
                        

                        position = dr.GetValue(2).ToString();
                        salary = dr.GetValue(3).ToString();
                        contact = dr.GetValue(4).ToString();
                        address = dr.GetValue(5).ToString();

                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID, " + Id + " Staff is not Available.   ");
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
            public void Add()
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");

                con.Open();
             
                try
                {
                    string str = "INSERT INTO staff1(name,gender,position,salary,contact,address) VALUES('" + name + "','" + gender + "','" + position + "','" + salary + "','" + contact + "','" + address + "'); ";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    string str1 = "select max(Id) from staff1;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Staff Information Saved Successfully..");
                       name = "";
                       position = "";
                         salary= "";
                        contact = "";
                        address = "";


                    }
                    
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
            public void Reset()
            {
                name = "";
                position = "";
                salary = "";
                contact = "";
                address = "";
                Id = "";

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            staffInfo ob = new staffInfo();
            ob.name = textBox2.Text;
            ob.position = textBox4.Text;
            ob.salary = textBox5.Text;
            ob.contact = textBox6.Text;
            ob.address = textBox7.Text;
            ob.search();
            display();
        }
        
       
        private void button4_Click(object sender, EventArgs e)
        {
            staffInfo ob = new staffInfo();
            ob.name = textBox2.Text;
            ob.position = textBox4.Text;
            ob.salary = textBox5.Text;
            ob.contact = textBox6.Text;
            ob.address = textBox7.Text;
            ob.Update();
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            staffInfo ob1 = new staffInfo();
            ob1.Id = textBox1.Text;
            ob1.name = textBox2.Text;
            ob1.position = textBox4.Text;
            ob1.salary = textBox5.Text;
            ob1.contact = textBox6.Text;
            ob1.address = textBox7.Text;
            ob1.Reset();

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            display();
        }
    }
}
