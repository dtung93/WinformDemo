using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace TungD
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            dgvaccount.AutoGenerateColumns = false;
        }
        private void load()
        {
            dgvaccount.DataSource = AccountBUS.getall();

        }
        private void Account_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
                AccountDTO account = new AccountDTO();
            try
            {
                account.username = txtusername.Text;
                account.password = txtpassword.Text;
                account.email = txtemail.Text;
                account.address = txtaddress.Text;
                account.name = txtname.Text;
                account.phone = txtphone.Text;
                account.admin = admin.Checked;
                account.status = admin.Checked;
                if(txtusername.Text==""||txtpassword.Text=="")
                { throw new Exception("TEN DANG NHAP VA MAT KHAU KHONG DUOC BO TRONG"); }
                if (AccountBUS.add(account))
                {
                    load();
                }
                else { MessageBox.Show("Them tai khoan that bai"); }
            }
            catch (Exception error) { MessageBox.Show("Da co loi xay ra "+error.ToString());}
           
        }

        private void dgvaccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string row = dgvaccount.SelectedRows[0].Cells["colusername"].Value.ToString();
            AccountDTO account = AccountBUS.getbyusername(row);
            txtusername.Text = account.username;
            txtpassword.Text = account.password;
            txtaddress.Text = account.address;
            txtemail.Text = account.email;
            txtphone.Text = account.phone;
            txtname.Text = account.name;
            admin.Checked = account.admin;
            status.Checked = account.status;
        }
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AccountDTO account = new AccountDTO();
            account.username = txtusername.Text;
            account.password = txtpassword.Text;
            account.phone = txtphone.Text;
            account.email = txtemail.Text;
            account.address = txtaddress.Text;
            account.name = txtname.Text;
            account.admin = admin.Checked;
            account.status = status.Checked;
            if (AccountBUS.edit(account))
            {
                load();
            }
            else { MessageBox.Show("Failed to edit!");}
        }

        private void dgvaccount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string username = dgvaccount.SelectedRows[0].Cells["colusername"].Value.ToString();
                dgvaccount.DataSource= AccountBUS.remove(username);
                load();
            }
            else { MessageBox.Show("Failed to delete!");}
        }
    }
}
