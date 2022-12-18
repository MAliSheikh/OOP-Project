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
    class patientinfo : person
    {
        DAO database = new DAO();
        public patientinfo()
        {

        }
        public patientinfo(string id, string name)
        {
            //this.name = name;
            //this.id = id;


        }
      
        public DataTable search()
        {
            return database.searchpatient(this.id);

        }
        public void Update()
        {
            database.Updatedata(this.id,this.name, this.gen, this.age, this.date, this.cont, this.addr, this.disease, this.r_type, this.building, this.r_no, this.price);
        }
        public void Delete()
        {          
        }
    }
}
