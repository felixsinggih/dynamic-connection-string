using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DynamicallyConnectionString
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "user1";
            txtPassword.Text = "user1";
            //string connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};", "localhost", "test_1", "root", "");
            string connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};", "156.67.211.160", "u2784109_siakop_master", "u2784109_testapp", "logika123");
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.isConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("cn", connectionString);
                    //MessageBox.Show("Use Master Connection.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserService sp = new UserService();
            String cek = sp.LoginChangeDatabase(txtUsername.Text, txtPassword.Text);
            if (cek != "")
            {
                //string connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};", "localhost", Seession.sees_database, "root", "");
                //try
                //{
                //    SqlHelper helper = new SqlHelper(connectionString);
                //    if (helper.isConnection)
                //    {
                //        AppSetting setting = new AppSetting();
                //        setting.SaveConnectionString("cn", connectionString);
                        //MessageBox.Show("Connection Has Changed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form2 frm = new Form2();
                        frm.Show();
                        this.Hide();
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            else
            {
                MessageBox.Show("Maaf, Username/Password Salah!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
