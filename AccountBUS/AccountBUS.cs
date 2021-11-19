using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
  public  class AccountBUS
    {
        public static bool checklogin(string tentaikhoan,string matkhau)
        {
            return AccountDAO.Checklogin(tentaikhoan, matkhau);

        }
        public static List<AccountDTO> getall()
        {
            DataTable dtb = AccountDAO.Getall();
            List<AccountDTO> account = new List<AccountDTO>();
            foreach(DataRow row in dtb.Rows)
            {
                AccountDTO a = new AccountDTO(row);
                account.Add(a);

            }return account;
        }
        public static AccountDTO getbyusername(string username)
        {
            if (AccountDAO.checkaccountexist(username))
            {
                DataRow row = AccountDAO.getaccountbyusername(username);
                AccountDTO account = new AccountDTO(row);
                return account;
            }return null;

        }
        public static bool remove(string username)
        {
            return AccountDAO.Remove(username);
        }
        public static bool add(AccountDTO account)
        {
            if (!AccountDAO.checkaccountexist(account.username))
            {
                return AccountDAO.Add(account);
            }
            return false;
        }
        public static bool edit(AccountDTO account)
        {
            if (AccountDAO.checkaccountexist(account.username))
            {
                return AccountDAO.Edit(account);
            }
            return false;
        }
    }
}
