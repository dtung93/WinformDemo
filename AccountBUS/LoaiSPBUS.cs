using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
namespace BUS
{
   public class LoaiSPBUS
    {
        public static DataTable getall()
        {
            return LoaiSPDAO.getall();
        }
    }
}
