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
    public static class User
    {
       
            public static string username="hms";
            private static string pass="ali";
            public static string property
            {
            get { return pass; }
            set
            {
                if (pass=="ali")
                {
                }
                
            }
            }
           
           
        
    }
}
