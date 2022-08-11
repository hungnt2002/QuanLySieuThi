using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;
namespace BLL
{

    public class ProductBLL
    {
        public bool insert(string tenSanPham, int soLuong, int gia, string phanLoai, string nhaSanXuat)
        {
            Product product = new Product(tenSanPham, soLuong, gia, phanLoai, nhaSanXuat);
            string query = "INSERT INTO tblProduct VALUES(@tenSanPham, @soLuong, @gia, @phanLoai, @nhaSanXuat)";
            ProductDAL productDAL = new ProductDAL();
            productDAL.Command(product, query);
    
            return true;
        }

        public bool update(string tenSanPham, int soLuong, int gia, string phanLoai, string nhaSanXuat)
        {
            Product product = new Product(tenSanPham, soLuong, gia, phanLoai, nhaSanXuat);
            string query = "UPDATE tblProduct" +
                " SET soLuong = @soLuong, gia = @gia, phanLoai = @phanLoai, nhaSanXuat = @nhaSanXuat" +
                " WHERE tenSanPham = @tenSanPham";
            ProductDAL productDAL = new ProductDAL();
            if(productDAL.Command(product, query))
            {
                return true;
            }

            return false;
        }

        public bool delete(string tenSanPham)
        {
            Product product = new Product(tenSanPham, 0, 0, "", "");
            string query = "DELETE FROM tblProduct WHERE tenSanPham = @tenSanPham";
            ProductDAL productDAL = new ProductDAL();
            if(productDAL.Command(product, query))
            {
                return true;
            }

            return false;
        }

        public DataTable loadAll()
        {
            QuerySelect querySelect = new QuerySelect();
            string query = "SELECT * FROM tblProduct";
            DataTable dataTable = querySelect.Select(query);
            return dataTable; 

        }

        public DataTable selectTenSanPhamTheoLoai(string tenSanPham,String loai)
        {
            string query;
            QuerySelect querySelect = new QuerySelect();
            if (loai == "Tất cả")
            {
                 query = "SELECT * FROM tblProduct WHERE tenSanPham like N'%" + tenSanPham + "%'";
            }
            else
            {

                query = "SELECT * FROM tblProduct WHERE tenSanPham like N'%"+tenSanPham+"%' AND phanLoai like N'%"+loai+"%'";
            }
            DataTable dataTable = querySelect.Select(query);
            return dataTable;

        }

        public DataTable selectLoai(string loai)
        {

            QuerySelect querySelect = new QuerySelect();
            string query = "SELECT * FROM tblProduct WHERE phanLoai = N'" + loai + "'";
            DataTable dataTable = querySelect.Select(query);
            return dataTable;

        }

    }
}
