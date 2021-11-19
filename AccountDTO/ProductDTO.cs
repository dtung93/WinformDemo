using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
  public  class ProductDTO
    {
        public string masp { get; set; }
        public string tensp { get; set; }
        public int price { get; set; }
        public string info { get; set; }
        public int SL { get; set; }
        public string anhminhhoa { get; set; }
        public string maloai { get; set; }
        public bool status { get; set; }
        public ProductDTO()
        {
            price = 0;
            anhminhhoa = "";
            SL = 0;
            status = true;
        }
        public ProductDTO(DataRow row)
        {
            masp = row["MaSP"].ToString();
            tensp = row["TenSP"].ToString();
            price = Convert.ToInt32(row["GiaTien"]);
            info = row["ThongTin"].ToString();
            SL = Convert.ToInt32(row["SoLuongTonKho"]);
            maloai = row["MaLoaiSP"].ToString();
            status = Convert.ToBoolean(row["TrangThai"]);
        }
    }
  
}
