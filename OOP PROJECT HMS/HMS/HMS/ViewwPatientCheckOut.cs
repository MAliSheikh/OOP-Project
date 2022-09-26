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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True");
        public void display()
        {

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From checkout1", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewPatientCheckout ob = new viewPatientCheckout();
            ob.ID = textBox1.Text;
            ob.Search();
            display();
        }
        public class viewPatientCheckout
        {
            public string ID;
            public void Search()
            {
                using (SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-NB836MV\SQLEXPRESS;Initial Catalog=hms;Integrated Security=True"))
                {

                    string str2 = "SELECT * FROM checkout1 where id='" + ID+ "'";
                    SqlCommand cmd2 = new SqlCommand(str2, con1);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                }
            
            
            }
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
