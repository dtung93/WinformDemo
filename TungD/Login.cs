using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;
namespace TungD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string tentaikhoan = txtlogin.Text;
                string matkhau = txtpassword.Text;
                if (txtlogin.Text == "" || txtpassword.Text=="")
                {
                    throw new Exception("TEN DANG NHAP VA MAT KHAU KHONG DUOC BO TRONG");

                }

                if (AccountBUS.checklogin(tentaikhoan, matkhau))
                {
                    MessageBox.Show("Welcome!");
                }
                else { MessageBox.Show("Login failed! Please check your username or password"); }
            }
            catch(ArgumentNullException error)
            {
                MessageBox.Show("Xin hay nhap day du thong tin "+error.ToString());
            }



       }
    }
}
