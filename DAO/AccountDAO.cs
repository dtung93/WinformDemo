using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
  public  class AccountDAO
    {
        public static bool Checklogin(string tentaikhoan, string matkhau)
        {
            string query = $"select count(*) from taikhoan where @tentaikhoan=tentaikhoan and @matkhau=matkhau";
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@tentaikhoan", tentaikhoan);
            pr[1] = new SqlParameter("@matkhau",matkhau);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pr).Rows[0][0]) == 1;
        }
        public static DataTable Getall()
        {
            string truyvan = "select * from taikhoan";
            SqlParameter[] pr = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(truyvan, pr);
        }
        public static DataRow getaccountbyusername(string username)
        {
            string truyvan = "select * from taikhoan where tentaikhoan=@username";
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@username", username);
            return DataProvider.ExecuteSelectQuery(truyvan, pr).Rows[0];
        }
        public static bool checkaccountexist(string username)
        {
            string truyvan = "select count(*) from taikhoan where tentaikhoan=@username";
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@username", username);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(truyvan, pr).Rows[0][0])==1;

        }
        public static bool Add(AccountDTO account)
        {
            string truyvan = "insert into taikhoan values(@tentaikhoan,@matkhau,@email,@sdt,@diachi,@hoten,@laadmin,@AnhDaiDien, @trangthai)";
            SqlParameter[] pr = new SqlParameter[9];
            pr[0] = new SqlParameter("@tentaikhoan", account.username);
            pr[1] = new SqlParameter("@matkhau", account.password);
            pr[2] = new SqlParameter("@email", account.email);
            pr[3] = new SqlParameter("@sdt", account.phone);
            pr[4] = new SqlParameter("@diachi", account.address);
            pr[5] = new SqlParameter("@hoten", account.name);
            pr[6] = new SqlParameter("@laadmin", account.admin);
            pr[7] = new SqlParameter("@AnhDaiDien", account.AnhDaiDien);
            pr[8] = new SqlParameter("@trangthai", account.status);
            return DataProvider.ExecuteNonQuery(truyvan,pr) == 1;

        }
        public static bool Edit(AccountDTO account)
        {
            string truyvan = "update taikhoan set matkhau=@matkhau,email=@email,sdt=@sdt,diachi=@diachi,hoten=@hoten,laadmin=@laadmin,anhdaidien=@anhdaidien,trangthai=@trangthai WHERE TenTaiKhoan=@TenTaiKhoan";
            SqlParameter[] pr = new SqlParameter[9];
            pr[0] = new SqlParameter("@tentaikhoan", account.username);
            pr[1] = new SqlParameter("@matkhau", account.password);
            pr[2] = new SqlParameter("@email", account.email);
            pr[3] = new SqlParameter("@sdt", account.phone);
            pr[4] = new SqlParameter("@diachi", account.address);
            pr[5] = new SqlParameter("@hoten", account.name);
            pr[6] = new SqlParameter("@laadmin", account.admin);
            pr[7] = new SqlParameter("@anhdaidien", account.AnhDaiDien);
            pr[8] = new SqlParameter("@trangthai", account.status);
            return DataProvider.ExecuteNonQuery(truyvan, pr) == 1;
        }
        public static bool Remove(string tentaikhoan)
        {
            string truyvan = "delete from taikhoan where tentaikhoan=@tentaikhoan";
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@tentaikhoan", tentaikhoan);
            return DataProvider.ExecuteNonQuery(truyvan, pr) == 1;

        }
    }
}
