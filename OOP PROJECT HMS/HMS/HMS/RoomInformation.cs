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
    public partial class RoomInformation : Form
    {
        public RoomInformation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");


        public void display()
        {

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From room1", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public class roomInfo
        {
            public string building;
            public string r_type;
            public string room_no;
            public string bed_no;
            public string price;
            public string r_status;
            public void ADD()
            { 
             SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");
                con.Open();

            try
            {
                string str = "INSERT INTO room1(building,r_type,room_no,bed_no,price,r_status) VALUES('" + building + "','" + r_type + "','" + room_no + "','" + bed_no + "','" + price + "','" + r_status + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(Id) from room1;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("room Information Saved Successfully..");
                   building = "";
                    room_no = "";
                    r_status = "";
                    r_type = "";
                    price = "";
                    bed_no = "";
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sem.4\C# Projects\Trials\HospitalManagementSystemCSharp\HospitalManagementSystemCSharp\hospital.mdf;Integrated Security=True"))
                    {

                        string str2 = "SELECT * FROM room1";
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            roomInfo ob = new roomInfo();
            ob.building = textBox1.Text;
            ob.r_type = textBox2.Text;
            ob.room_no = textBox3.Text;
            ob.bed_no = textBox4.Text;
            ob.r_status=textBox5.Text;
            ob.ADD();
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";

        }
    }
}
