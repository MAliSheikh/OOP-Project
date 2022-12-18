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
   

    public class PatientRegistration:person
    {
        DAO database = new DAO();

       
        public  void PatientBill(string p)
        {
            this.price = p;
        }
        
        public void Register()
        {
            database.insert(this.id,this.name, this.gen, this.age, this.date, this.cont, this.addr, this.disease, this.r_type, this.building, this.r_no, this.price);

        }
    }
}
