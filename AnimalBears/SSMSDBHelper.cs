using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalBears
{
    public class SSMSDBHelper
    {
        public static SqlConnection GetConnection()
        {
            string con = "Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=AnimalDB;Integrated Security=True";
            return new SqlConnection(con);
        }
    }
}
