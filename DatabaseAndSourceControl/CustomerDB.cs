using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAndSourceControl
{
    static class CustomerDB
    {
        public static List<string> GetAllNames()
        {
            //
            string connection = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=CustomerDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                //TODO; finish database code...
            }

            //Same as above, but above doesn't do exception handling
            //SqlConnection con = new SqlConnection(connection);

            //try
            //{
            //    con.Open();
            //}
            //finally 
            //{

            //    con.Dispose();
            //}
        }
    }
}
