using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class AccountDTO
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public bool admin { get; set; }
        public string AnhDaiDien { get; set; }
        public bool status { get; set; }
    public AccountDTO()
        {
            
            admin = true;
            AnhDaiDien = "";
            status = true;
        }
public AccountDTO(DataRow row)
        {
            username = row["TenTaiKhoan"].ToString();
            password = row["MatKhau"].ToString();
            email = row["Email"].ToString();
            phone=row["SDT"].ToString();
            address=row["DiaChi"].ToString();
            name=row["HoTen"].ToString();
            admin = Convert.ToBoolean(row["LaAdmin"]);
            status = Convert.ToBoolean(row["TrangThai"]);
        }

    }
}
