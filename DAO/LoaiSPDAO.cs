using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
  public  class LoaiSPDAO
    {
        public static DataTable getall()
        {
            string truyvan = "select * from loaisanpham";
            SqlParameter[] pr = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(truyvan, pr);
        }
    }
}
