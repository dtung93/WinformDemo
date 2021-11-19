
namespace TungD
{
    partial class Account
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvaccount = new System.Windows.Forms.DataGridView();
            this.colusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmatkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.CheckBox();
            this.status = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten Tai Khoan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mat khau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "So DT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dia Chi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ho ten";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "La Admin?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Trang Thai";
            // 
            // dgvaccount
            // 
            this.dgvaccount.AllowUserToAddRows = false;
            this.dgvaccount.AllowUserToDeleteRows = false;
            this.dgvaccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvaccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvaccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colusername,
            this.colmatkhau,
            this.colemail,
            this.colsdt,
            this.coldiachi,
            this.colname,
            this.coladmin,
            this.coltrangthai});
            this.dgvaccount.Location = new System.Drawing.Point(24, 222);
            this.dgvaccount.Name = "dgvaccount";
            this.dgvaccount.ReadOnly = true;
            this.dgvaccount.RowHeadersVisible = false;
            this.dgvaccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvaccount.Size = new System.Drawing.Size(764, 150);
            this.dgvaccount.TabIndex = 9;
            this.dgvaccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvaccount_CellDoubleClick);
            this.dgvaccount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvaccount_KeyUp);
            // 
            // colusername
            // 
            this.colusername.DataPropertyName = "username";
            this.colusername.HeaderText = "Ten TK";
            this.colusername.Name = "colusername";
            this.colusername.ReadOnly = true;
            // 
            // colmatkhau
            // 
            this.colmatkhau.DataPropertyName = "password";
            this.colmatkhau.HeaderText = "Mat khau";
            this.colmatkhau.Name = "colmatkhau";
            this.colmatkhau.ReadOnly = true;
            // 
            // colemail
            // 
            this.colemail.DataPropertyName = "Email";
            this.colemail.HeaderText = "Email";
            this.colemail.Name = "colemail";
            this.colemail.ReadOnly = true;
            // 
            // colsdt
            // 
            this.colsdt.DataPropertyName = "phone";
            this.colsdt.HeaderText = "So DT";
            this.colsdt.Name = "colsdt";
            this.colsdt.ReadOnly = true;
            // 
            // coldiachi
            // 
            this.coldiachi.DataPropertyName = "address";
            this.coldiachi.HeaderText = "Dia chi";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.ReadOnly = true;
            // 
            // colname
            // 
            this.colname.DataPropertyName = "name";
            this.colname.HeaderText = "Ho ten";
            this.colname.Name = "colname";
            this.colname.ReadOnly = true;
            // 
            // coladmin
            // 
            this.coladmin.DataPropertyName = "admin";
            this.coladmin.HeaderText = "Admin?";
            this.coladmin.Name = "coladmin";
            this.coladmin.ReadOnly = true;
            // 
            // coltrangthai
            // 
            this.coltrangthai.DataPropertyName = "status";
            this.coltrangthai.HeaderText = "Trang Thai";
            this.coltrangthai.Name = "coltrangthai";
            this.coltrangthai.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(108, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Them";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(208, 181);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sua";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(105, 20);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(311, 20);
            this.txtusername.TabIndex = 13;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(105, 75);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(311, 20);
            this.txtemail.TabIndex = 14;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(105, 46);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(311, 20);
            this.txtpassword.TabIndex = 15;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(105, 133);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(311, 20);
            this.txtaddress.TabIndex = 16;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(105, 107);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(311, 20);
            this.txtphone.TabIndex = 17;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(508, 24);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(280, 20);
            this.txtname.TabIndex = 18;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(528, 64);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(44, 17);
            this.admin.TabIndex = 20;
            this.admin.Text = "Yes";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(528, 87);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(44, 17);
            this.status.TabIndex = 21;
            this.status.Text = "Yes";
            this.status.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.status);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvaccount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Account";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvaccount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.CheckBox admin;
        private System.Windows.Forms.CheckBox status;
        private System.Windows.Forms.DataGridViewTextBoxColumn colusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmatkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn coladmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrangthai;
    }
}

