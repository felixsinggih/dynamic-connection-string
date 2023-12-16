using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DynamicallyConnectionString
{
    public partial class Form1 : Form
    {
        public String _user;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboServer.Items.Add(".");
            cboServer.Items.Add("(local)");
            cboServer.Items.Add("localhost");
            cboServer.Items.Add(@".\SQLEXPRESS");
            cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cboServer.SelectedIndex = 2;

            txtDatabase.Text = "test_";
            txtUsername.Text = "root";
            txtUser.Text = "user";
            txtPass.Text = "user";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.isConnection)
                    MessageBox.Show("Test Connection Succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.isConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("cn", connectionString);
                    MessageBox.Show("Your Connection String Has Been Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (sp.CekLogin(txtUser.Text, txtPass.Text) != "")
            {
                //lblTest.Text = sp.CekLogin(txtUser.Text, txtPass.Text);
                //MessageBox.Show(sp.CekLogin(txtUser.Text, txtPass.Text), "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Maaf, Username/Password Salah!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
