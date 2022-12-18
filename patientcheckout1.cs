using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OOP_Project_HMS
{
    class patientcheckout1 : person
    {
        DAO database = new DAO();
        public string disease;
        public string date_in;
        public string date_out;
        public string build;
        public string status;
        public string med_price;
        public string total;
        
        public void insert()
        {
            database.insert(this.id,this.name,  this.gen, this.age, this.cont, this.addr, this.disease, this.date_in, this.date_out, this.build, this.r_no, this.r_type, this.status, this.med_price, this.total);          
        }
        public DataTable view()
        {
            return database.checkout1(this.id);

        }
    }
}
