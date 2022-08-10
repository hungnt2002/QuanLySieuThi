using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    internal class ProductDAL
    {
        SqlConnection conn = null;
        SqlCommand cmd;
        public bool Command(Product product, string query)
        {
            conn = Connection.getConnection();

            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = product.TenSanPham;
                cmd.Parameters.Add("@soLuong", SqlDbType.Int).Value = product.SoLuong;
                cmd.Parameters.Add("@gia", SqlDbType.Int).Value = product.Gia;
                cmd.Parameters.Add("@phanLoai", SqlDbType.NVarChar).Value = product.PhanLoai;
                cmd.Parameters.Add("@nhaSanXuat", SqlDbType.NVarChar).Value = product.NhaSanXuat;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }


        
    }
}
