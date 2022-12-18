using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OOP_Project_HMS
{
    class doc:staffinfo
    {
        DAO database = new DAO();
        public string qualification;
        public doc()
        {

        }
        public void insertdocdata()
        {
            database.instertdoctor(this.id, this.name, this.gen, this.age, this.qualification, this.salary, this.cont, this.addr);
        }
        public DataTable Searchdata()
        {
            return database.searchdoctor(this.id);
        }
        public void updatedata()
        {
            database.updatedoctor(this.id, this.name, this.gen, this.age, this.qualification, this.salary, this.cont, this.addr);
        }
    }
}
