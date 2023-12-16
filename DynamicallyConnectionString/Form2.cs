using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DynamicallyConnectionString
{
    public partial class Form2 : Form
    {
        UserService user = new UserService();
        public Form2()
        {
            InitializeComponent();
        }

        void Tampil()
        {
            dgvUser.DataSource = user.Tampil();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtSessUser.Text = Seession.sees_user;
            txtSeesDatabase.Text = Seession.sees_database;
            Tampil();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("NIDN wajib diisi!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Nama wajib diisi!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                if (!(user.Cek(txtUsername.Text.Trim())))
                {
                    user.USERNAME = txtUsername.Text.Trim();
                    user.PASSWORD = txtPassword.Text.Trim();

                    user.Simpan();
                    Tampil();
                }
                else
                {
                    MessageBox.Show("Username " + txtUsername.Text + " sudah dipakai!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name == "aksi")
            {
                DataGridViewRow row = this.dgvUser.Rows[e.RowIndex];
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (user.Cek(txtUsername.Text.Trim()))
            {
                if (MessageBox.Show("Data tersebut akan diubah? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    user.USERNAME = txtUsername.Text.Trim();
                    user.PASSWORD = txtPassword.Text.Trim();

                    user.Ubah(txtUsername.Text.Trim());
                    Tampil();
                }
            }
        }

        private void btnResfresh_Click(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data tersebut akan dihapus? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                user.Hapus(txtUsername.Text.Trim());
                Tampil();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Seession.sees_user = "";
            Seession.sees_database = "";
            Form3 frm = new Form3();
            frm.Show();
            this.Close();
        }

        //coba

        struct DataParameter
        {
            public int Proccess;
            public int Delay;
        }

        private DataParameter _inputparameter;


        private void BackWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //int proccess = ((DataParameter)e.Argument).Proccess;
            //int delay = ((DataParameter)e.Argument).Delay;
            //int index = 1;
            //try
            //{
            //    for (int i = 0; i < proccess; i++)
            //    {
            //        if (!BackWorker.CancellationPending)
            //        {
            //            BackWorker.ReportProgress(index++ * 100 / proccess, string.Format("Proccess data {0}", i));
            //            Thread.Sleep(delay);
            //            //Simpan();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    BackWorker.CancelAsync();
            //    MessageBox.Show(ex.Message, "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            for (int i = 1; 1 < 100; i++)
            {
                Thread.Sleep(10);
                BackWorker.WorkerReportsProgress = true;
                BackWorker.ReportProgress(i);
            }
        }

        private void BackWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //ProgBar.Value = e.ProgressPercentage;
            //LblProg.Text = string.Format("Processing...{0}%", e.ProgressPercentage);
            //ProgBar.Update();
            ProgBar.Value = e.ProgressPercentage;
            LblProg.Text = e.ProgressPercentage.ToString() + "%";
            if (LblProg.Text == "100%")
            {

            }
        }

        private void BackWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Data Insert Success", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSimpanProggress_Click(object sender, EventArgs e)
        {
            //if (!BackWorker.IsBusy)
            //{
            //    _inputparameter.Delay = 100;
            //    _inputparameter.Proccess = 1200;
            //    BackWorker.RunWorkerAsync(_inputparameter);
            //}
            Simpan();
            BackWorker.RunWorkerAsync();
        }

        private void Simpan()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                if (!(user.Cek(txtUsername.Text.Trim())))
                {
                    user.USERNAME = txtUsername.Text.Trim();
                    user.PASSWORD = txtPassword.Text.Trim();
                    user.Simpan();
                }
                else
                {
                    MessageBox.Show("Username " + txtUsername.Text + " sudah dipakai!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        
    }
}
