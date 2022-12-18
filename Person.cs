using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OOP_Project_HMS
{
    public class person:rules
    { 
        public string id { get; set; }
        public string name { get; set; }
        public string gen { get; set; }
        public string age { get; set; }
        public string date;
        public string cont { get; set; }
        public string addr { get; set; }
        public string disease;
        public string status;
        public string r_type;
        public string building;
        public string r_no;
        public string price;

    }
}

