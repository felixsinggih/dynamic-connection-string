using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace DynamicallyConnectionString
{
    class SQLService : SQLConn
    {
        MySqlConnection cn;
        //Configuration config;
        private String strCon = "";
        private MySqlCommand sComm;
        private MySqlDataAdapter dtAdp;
        public String query;

        public SQLService()
        {
            strCon = ConStr();
            cn = new MySqlConnection(strCon);
            sComm = new MySqlCommand();
            dtAdp = new MySqlDataAdapter();
        }

        public string ConStr()
        {
            //return ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            AppSetting setting = new AppSetting();
            return setting.GetConnectionString("cn");
        }

        public void openConnection()
        {
            if (cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();
                }
                catch (Exception)
                { }
            }
        }

        public void closeConnection()
        {
            cn.Close();
        }

        public override int ExecNonQuery(String query)
        {
            int retVal = -1;

            try
            {
                openConnection();
                sComm.Connection = cn;
                sComm.CommandText = query;
                retVal = sComm.ExecuteNonQuery();
            }
            catch (Exception)
            { }
            finally
            {
                closeConnection();
            }

            return retVal;
        }

        public override DataTable ExecQuery(String query)
        {
            DataTable retVal = new DataTable();

            try
            {
                openConnection();
                sComm.Connection = cn;
                sComm.CommandText = query;
                dtAdp.SelectCommand = sComm;
                dtAdp.Fill(retVal);
            }
            catch (Exception)
            { }
            finally
            {
                closeConnection();
            }

            return retVal;
        }
    }
}
