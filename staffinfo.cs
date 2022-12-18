using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace OOP_Project_HMS
{
    class staffinfo : person
    {
        DAO database = new DAO();
            
        public string position;
        public string salary;
        public staffinfo()
        {
            //this.position = "";
            //this.salary = "";
        }
        public void insertstaffdata()
        {
            database.insert(this.id, this.name, this.gen, this.age, this.position, this.salary, this.cont, this.addr);
        }
        public DataTable searchdata()
        {
            return database.searchstaff(this.id);
        }
        public void updatedta()
        {
            database.Updatestaaffdata(this.id, this.name, this.gen, this.age, this.position, this.salary, this.cont, this.addr);
        }
    }
}
