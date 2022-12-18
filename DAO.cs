using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOP_Project_HMS
{
    class DAO
    {
        public SqlConnection con = new SqlConnection(@"Data Source=MR-SHEIKH\SQLEXPRESS;Initial Catalog=oop_project;Integrated Security=True");

        public void insert(string id, string name, string gender, string Age, string dates, string contact, string address, string diseases, string rtype, string Building, string rno, string Price)
        {
            string str = "INSERT INTO patient(id,name,gen,age,date,cont,addr,disease,r_type,building,r_no,price) VALUES('" + id + "','" + name + "','" + gender + "','" + Age + "','" + dates + "','" + contact + "','" + address + "','" + diseases + "','" + rtype + "','" + Building + "','" + rno + "','" + Price + "'); ";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public DataTable searchpatient(string id)
        {
            con.Open();
            string getCust = "select name,gen,age,date,cont,addr,disease,r_type,building,r_no,price from patient where id='" + id + "' ;";

            DataTable ali = new DataTable();
            SqlCommand cmd = new SqlCommand(getCust, con);

            SqlDataAdapter a = new SqlDataAdapter(cmd);
            a.Fill(ali);


            con.Close();

            return ali;
        }
        public void Updatedata(string id,string name, string gen, string age, string date, string cont, string addr, string disease, string rtype, string building, string rno, string Price)
        {
            string str = " Update patient set name='" + name + "',gen='" + gen + "',age='" + age + "',date='" + date + "',cont='" + cont + "',addr='" + addr + "',disease='" + disease + "',r_type='" + rtype + "',building='" + building + "',r_no='" + rno + "',price='" + Price + "' where id='" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void deletedata(string id)
        {
            string str = "DELETE FROM patient WHERE id = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Patient Record Delete Successfully");
           
        }

        public void insert(string id,string name,string gen,string age, string contact, string addr,string disease, string date_in, string date_out,string build, string r_no, string r_type, string status, string med_price, string total)
        {
            string str = "INSERT INTO checkout3 VALUES('" + id + "','" + name + "','" + gen + "','" + age + "','" + contact + "','" + addr + "','" + disease + "','" + date_in + "','" + date_out + "','" + build + "','" + r_no + "','" + r_type + "','" + status + "','" + med_price + "','" + total + "'); ";

            con.Open();
            SqlCommand cmd1 = new SqlCommand(str, con);
            cmd1.ExecuteNonQuery();
            con.Close();
        }
        public DataTable checkout1(string id)
        {
            con.Open();
            string getCust = "select id,name,gen,age,contact,addr,disease,date_in,date_out,build,r_no,r_type,status,med_price,total from checkout3 where id='" + id + "' ;";

            DataTable ali = new DataTable();
            SqlCommand cmd = new SqlCommand(getCust, con);

            SqlDataAdapter a = new SqlDataAdapter(cmd);
            a.Fill(ali);


            con.Close();

            return ali;
        }
        public void insert(string id, string name, string gen,string age,string position,string salary,string contact,string address)
        {
            string str = "INSERT INTO staffinformation VALUES('" + id + "','"+ name + "','" + gen + "','" + age + "','" + position + "','" + salary + "','" + contact + "','" + address + "'); ";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Updatestaaffdata(string id, string name, string gen, string age, string position, string salary, string contact, string address)
        {
            string str = "UPDATE staffinformation set sname='" + name + "',Gender='" + gen + "',Age='" + age + "',Positions='" + position + "',Salaries='" + salary + "',Contact='" + contact + "',Addr='" + address + "' where Id='" + id + "'";

            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public DataTable searchstaff(string id)
        {
            
            con.Open();
            string getCust = "select Id,sname,Gender,Age,Positions,Salaries,Contact,Addr from staffinformation where Id='" + id + "' ;";

            DataTable ali = new DataTable();
            SqlCommand cmd = new SqlCommand(getCust, con);

            SqlDataAdapter a = new SqlDataAdapter(cmd);
            a.Fill(ali);
            con.Close();
            return ali;
        }

        public staffinfo getStaff(string id)
        {
            con.Open();
            string getCust = "select * from staffinformation where Id='" + id + "' ;";

            SqlCommand cmd = new SqlCommand(getCust, con);

            SqlDataReader sdr = cmd.ExecuteReader();
            
            sdr.Read();

            if (sdr.HasRows)
            {
                staffinfo staff = new staffinfo();
                staff.name = sdr["sname"].ToString();
                staff.gen = sdr["Gender"].ToString();
                staff.age = sdr["Age"].ToString();
                staff.position = sdr["Positions"].ToString();
                staff.salary = sdr["Salaries"].ToString();
                staff.cont = sdr["Contact"].ToString();
                staff.addr = sdr["Addr"].ToString();
                con.Close();
                return staff;
            }
            else
            {
                //MessageBox.Show("no rows");
                con.Close();
                return null;
            }

        }
        public void instertdoctor(string id, string name, string gender, string age, string qualification, string salary, string contact, string address)
        {
            string str = "INSERT INTO doctor1  VALUES('" + id + "','" + name + "','" + gender + "','" + age + "','" + qualification + "','" + salary + "','" + contact + "','" + address + "'); ";
            con.Open();
            SqlCommand cmd3 = new SqlCommand(str, con);
            cmd3.ExecuteNonQuery();
            con.Close();
        }

        public void updatedoctor(string id, string name, string gender, string age, string qualification, string salary, string contact, string address)
        {
            string str = "UPDATE doctor1 set name='" + name + "',gender='" + gender + "',age='" + age + "',qualification='" + qualification+ "',salary='" + salary + "',contact='" + contact + "',address='" + address + "' where Id='" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable searchdoctor(string id)
        {
            con.Open();
            string getCust = "SELECT Id,name,gender,age,qualification,salary,contact,address from doctor1 where Id='" + id + "' ;";
            DataTable zaid = new DataTable();
            SqlCommand cmd = new SqlCommand(getCust, con);
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            a.Fill(zaid);
            con.Close();
            return zaid;
        }
        public doc getdoc(string id)
        {
            con.Open();
            string getCust = "select * from doctor1 where Id='" + id + "' ;";
            SqlCommand cmd = new SqlCommand(getCust, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
                doc dd = new doc();
                dd.name = sdr["name"].ToString();
                dd.gen = sdr["gender"].ToString();
                dd.age = sdr["age"].ToString();
                dd.qualification = sdr["qualification"].ToString();
                dd.salary = sdr["Salary"].ToString();
                dd.cont = sdr["contact"].ToString();
                dd.addr = sdr["address"].ToString();
                con.Close();
                return dd;
            }
            else
            {
                //MessageBox.Show("no rows");
                con.Close();
                return null;
            }

        }
        public patientinfo getpatient(string id)
        {
            con.Open();
            string getCust = "select * from patient where id='" + id + "' ;";
            SqlCommand cmd = new SqlCommand(getCust, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
                patientinfo pt = new patientinfo();
                pt.name = sdr["name"].ToString();
                pt.gen = sdr["gen"].ToString();
                pt.age = sdr["age"].ToString();
                pt.date = sdr["date"].ToString();
                pt.cont = sdr["cont"].ToString();
                pt.addr = sdr["addr"].ToString();
                pt.disease = sdr["disease"].ToString();
                pt.r_type = sdr["r_type"].ToString();
                pt.building = sdr["building"].ToString();
                pt.r_no = sdr["r_no"].ToString();
                pt.price = sdr["price"].ToString();
                con.Close();
                return pt;
            }
            else
            {
                con.Close();
                return null;
            }

        }
    }
}
