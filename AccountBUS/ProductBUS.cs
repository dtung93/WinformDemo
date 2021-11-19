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
  public  class ProductBUS
    {
        public static ProductDTO getproductbymasp(string masp)
        {
            if (ProductDAO.checkproductexist(masp))
            {
                DataRow row = ProductDAO.getproductbymasp(masp);
                ProductDTO product = new ProductDTO(row);
                return product;
            }
            return null;
        }
        public static List<ProductDTO> getall()
        {
            DataTable dtb = ProductDAO.getall();
            List<ProductDTO> product = new List<ProductDTO>();
            foreach (DataRow row in dtb.Rows)
            {
                ProductDTO p= new ProductDTO(row);
                product.Add(p);
            }return product;
        }
        public static bool Add(ProductDTO product)
        {
            if (!ProductDAO.checkproductexist(product.masp))
            {
                return ProductDAO.Add(product);
            }
            return false;
        }
        public static bool Edit(ProductDTO product)
        {
            if (ProductDAO.checkproductexist(product.masp))
            {
                return ProductDAO.Edit(product);
            }

            return false;
        }
        public static bool Delete(string masp)
        {
            return ProductDAO.Remove(masp);
        }
    }
}
