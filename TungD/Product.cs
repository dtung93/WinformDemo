using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace TungD
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            dgvproduct.AutoGenerateColumns = false;
        }
        private void loaddata()
        {
            dgvproduct.DataSource = ProductBUS.getall();
        }
        private void Product_Load(object sender, EventArgs e)
        {
            loaddata();
            cboxcategory.DataSource= LoaiSPBUS.getall();
            cboxcategory.DisplayMember = "TenLoaiSP";
            cboxcategory.ValueMember = "MaLoaiSP";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductDTO product = new ProductDTO();
            try
            {
                product.masp = txtmsp.Text;
                product.tensp = txtname.Text;
                if (txtmsp.Text == "" || txtname.Text == "")
                {
                    throw new Exception("MA SP VA TEN SP KHONG DUOC DE TRONG");
                }
                product.price = Convert.ToInt32(txtprice.Text);
                product.SL = Convert.ToInt32(numquantity.Value);
                product.info = txtinfo.Text;
                product.maloai = cboxcategory.SelectedValue.ToString();
                product.status = status.Checked;
                if (ProductBUS.Add(product))
                {
                    loaddata();

                }
                else { MessageBox.Show("Them TK That Bai"); }
            }
            catch (Exception error) { MessageBox.Show("Da co loi xay ra " + error.ToString()); }
            
            }
           
        private void dgvproduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string masp = dgvproduct.SelectedRows[0].Cells["colmsp"].Value.ToString();
            ProductDTO product = ProductBUS.getproductbymasp(masp);
            txtmsp.Text = product.masp;
            txtname.Text = product.tensp;
            txtprice.Text = product.price.ToString();
            txtinfo.Text = product.info;
            numquantity.Value = product.SL;
            status.Checked = product.status;
            cboxcategory.SelectedValue = product.maloai;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductDTO product = new ProductDTO();
            product.masp = txtmsp.Text;
            product.tensp = txtname.Text;
            product.info = txtinfo.Text;
            product.maloai = cboxcategory.SelectedValue.ToString();
            product.price = Convert.ToInt32(txtprice.Text);
            product.SL = Convert.ToInt32(numquantity.Value);
            product.status = status.Checked;
            if (ProductBUS.Edit(product))
            {
                loaddata();
            }
            else { MessageBox.Show("Edit failed");}
        }

        private void dgvproduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                string msp = dgvproduct.SelectedRows[0].Cells["colmsp"].Value.ToString();
                dgvproduct.DataSource = ProductBUS.Delete(msp);
                loaddata();
            }
            else { MessageBox.Show("Delete failed!");}
        }
    }
}
