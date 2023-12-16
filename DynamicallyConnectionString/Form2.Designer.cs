namespace DynamicallyConnectionString
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSessUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aksi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnResfresh = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtSeesDatabase = new System.Windows.Forms.Label();
            this.BtnSimpanProggress = new System.Windows.Forms.Button();
            this.LblProg = new System.Windows.Forms.Label();
            this.ProgBar = new System.Windows.Forms.ProgressBar();
            this.BackWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSessUser
            // 
            this.txtSessUser.AutoSize = true;
            this.txtSessUser.Location = new System.Drawing.Point(12, 9);
            this.txtSessUser.Name = "txtSessUser";
            this.txtSessUser.Size = new System.Drawing.Size(74, 13);
            this.txtSessUser.TabIndex = 0;
            this.txtSessUser.Text = "seession_user";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(73, 63);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(198, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(73, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(198, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(73, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.aksi});
            this.dgvUser.Location = new System.Drawing.Point(287, 41);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(361, 378);
            this.dgvUser.TabIndex = 6;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // aksi
            // 
            this.aksi.HeaderText = "Aksi";
            this.aksi.Name = "aksi";
            this.aksi.ReadOnly = true;
            this.aksi.Text = "Edit";
            this.aksi.UseColumnTextForButtonValue = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(154, 115);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "&Ubah";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnResfresh
            // 
            this.btnResfresh.Location = new System.Drawing.Point(287, 12);
            this.btnResfresh.Name = "btnResfresh";
            this.btnResfresh.Size = new System.Drawing.Size(75, 23);
            this.btnResfresh.TabIndex = 8;
            this.btnResfresh.Text = "&Refresh Data";
            this.btnResfresh.UseVisualStyleBackColor = true;
            this.btnResfresh.Click += new System.EventHandler(this.btnResfresh_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(117, 144);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "&Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(573, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtSeesDatabase
            // 
            this.txtSeesDatabase.AutoSize = true;
            this.txtSeesDatabase.Location = new System.Drawing.Point(92, 9);
            this.txtSeesDatabase.Name = "txtSeesDatabase";
            this.txtSeesDatabase.Size = new System.Drawing.Size(98, 13);
            this.txtSeesDatabase.TabIndex = 11;
            this.txtSeesDatabase.Text = "seession_database";
            // 
            // BtnSimpanProggress
            // 
            this.BtnSimpanProggress.Location = new System.Drawing.Point(73, 226);
            this.BtnSimpanProggress.Name = "BtnSimpanProggress";
            this.BtnSimpanProggress.Size = new System.Drawing.Size(156, 23);
            this.BtnSimpanProggress.TabIndex = 12;
            this.BtnSimpanProggress.Text = "&Simpan Proggress";
            this.BtnSimpanProggress.UseVisualStyleBackColor = true;
            this.BtnSimpanProggress.Click += new System.EventHandler(this.BtnSimpanProggress_Click);
            // 
            // LblProg
            // 
            this.LblProg.AutoSize = true;
            this.LblProg.Location = new System.Drawing.Point(12, 273);
            this.LblProg.Name = "LblProg";
            this.LblProg.Size = new System.Drawing.Size(55, 13);
            this.LblProg.TabIndex = 13;
            this.LblProg.Text = "Username";
            // 
            // ProgBar
            // 
            this.ProgBar.Location = new System.Drawing.Point(15, 290);
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.Size = new System.Drawing.Size(256, 23);
            this.ProgBar.TabIndex = 14;
            // 
            // BackWorker
            // 
            this.BackWorker.WorkerReportsProgress = true;
            this.BackWorker.WorkerSupportsCancellation = true;
            this.BackWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackWorker_DoWork);
            this.BackWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackWorker_ProgressChanged);
            this.BackWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackWorker_RunWorkerCompleted);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 431);
            this.Controls.Add(this.ProgBar);
            this.Controls.Add(this.LblProg);
            this.Controls.Add(this.BtnSimpanProggress);
            this.Controls.Add(this.txtSeesDatabase);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnResfresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSessUser);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSessUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewButtonColumn aksi;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnResfresh;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label txtSeesDatabase;
        private System.Windows.Forms.Button BtnSimpanProggress;
        private System.Windows.Forms.Label LblProg;
        private System.Windows.Forms.ProgressBar ProgBar;
        private System.ComponentModel.BackgroundWorker BackWorker;
    }
}