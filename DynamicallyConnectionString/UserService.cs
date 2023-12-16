using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DynamicallyConnectionString
{
    class UserService : User
    {
        SQLService dbServ; //database
        DataTable dtTmp; //temporary

        public UserService()
        {
            dbServ = new SQLService();
            dtTmp = new DataTable();
        }

        public String CekLogin(String kode, String pass)
        {
            String Auth = "";
            dbServ.query = "select * from user_test where username='" + kode + "' and password='" + pass + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                Auth = dtTmp.Rows[0][0].ToString();
                Seession.sees_user = Auth;
            }
            return Auth;
        }

        public DataTable Tampil()
        {
            dbServ.query = "select * from user_test";
            return dbServ.ExecQuery(dbServ.query);
        }

        public bool Cek(String kode)
        {
            bool cek = false;
            dbServ.query = "select * from user_test where username='" + kode + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public void Simpan()
        {
            dbServ.query = "insert into user_test values ('" + USERNAME + "', '" + PASSWORD + "')";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public void Ubah(String kode)
        {
            dbServ.query = "update user_test set password='" + PASSWORD + "' where username='" + kode + "'";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public void Hapus(String kode)
        {
            dbServ.query = "delete from user_test where username='" + kode + "'";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menghapus");
            }
        }

        public String LoginChangeDatabase(String kode, String pass)
        {
            String Auth = "";
            //String Database = "";
            dbServ.query = "select * from user_test where username='" + kode + "' and password='" + pass + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                Auth = dtTmp.Rows[0][0].ToString();
                //Database = dtTmp.Rows[0][2].ToString();
                Seession.sees_user = Auth;
                //Seession.sees_database = Database;
            }
            return Auth;
        }

        private void ChangeDatabase(String Database)
        {
            string connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};", "localhost", Database, "root", "");
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.isConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("cn", connectionString);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
