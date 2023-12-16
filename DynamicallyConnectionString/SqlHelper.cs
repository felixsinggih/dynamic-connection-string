using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DynamicallyConnectionString
{
    public class SqlHelper
    {
        MySqlConnection cn;

        public SqlHelper(String connectionString)
        {
            cn = new MySqlConnection(connectionString);
        }

        public bool isConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
