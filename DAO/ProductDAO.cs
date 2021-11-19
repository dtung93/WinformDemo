using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
   public class ProductDAO
    {
        public static DataTable getall()
        {
            string truyvan = "select * from sanpham";
            SqlParameter[] pr = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(truyvan, pr);

        }
        public static bool checkproductexist(string masp)
        {
            string truyvan = "select count(*) from sanpham where masp=@masp";
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@masp", masp);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(truyvan, pr).Rows[0][0]) == 1;
        }
        public static DataRow getproductbymasp(string masp)
        {
            string truyvan = "select * from sanpham where masp=@masp";
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@masp", masp);
            return DataProvider.ExecuteSelectQuery(truyvan, pr).Rows[0];
        }
        public static bool Add(ProductDTO product)
        {
            string truyvan = "insert into sanpham values(@masp,@tensp,@thongtin,@giatien,@soluongtonkho,@maloaisp,@anhminhhoa,@trangthai)";
            SqlParameter[] pr = new SqlParameter[8];
            pr[0]= new SqlParameter("@masp", product.masp);
            pr[1]= new SqlParameter("@tensp", product.tensp);
            pr[2]= new SqlParameter("@thongtin", product.info);
            pr[3] = new SqlParameter("@giatien", product.price);
            pr[4] = new SqlParameter("@soluongtonkho", product.SL);
            pr[5]= new SqlParameter("@maloaisp", product.maloai);
            pr[6]= new SqlParameter("@anhminhhoa", product.anhminhhoa);
            pr[7]= new SqlParameter("@trangthai", product.status);
            return DataProvider.ExecuteNonQuery(truyvan, pr)==1;

        }
        public static bool Edit(ProductDTO product)
        {
            string truyvan = "update sanpham set tensp=@tensp,thongtin=@thongtin,giatien=@giatien,soluongtonkho=@soluongtonkho,maloaisp=@maloaisp,anhminhhoa=@anhminhhoa,trangthai=@trangthai where masp=@masp";
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("@masp", product.masp);
            pr[1] = new SqlParameter("@tensp", product.tensp);
            pr[2] = new SqlParameter("@thongtin", product.info);
            pr[3] = new SqlParameter("@giatien", product.price);
            pr[4] = new SqlParameter("@soluongtonkho", product.SL);
            pr[5] = new SqlParameter("@maloaisp", product.maloai);
            pr[6] = new SqlParameter("@anhminhhoa", product.anhminhhoa);
            pr[7] = new SqlParameter("@trangthai", product.status);
            return DataProvider.ExecuteNonQuery(truyvan, pr) == 1;
        }
        public static bool Remove(string masp)
        {
            string truyvan = "delete from sanpham where masp=@masp";
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@masp", masp);
            return DataProvider.ExecuteNonQuery(truyvan, pr) == 1;
        }
    }
}
