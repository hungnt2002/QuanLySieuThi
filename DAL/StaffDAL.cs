﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class StaffDAL
    {
        private SqlConnection conn = null;
        private SqlCommand cmd;
        public bool Command(Staff staff, string query)
        {
            conn = Connection.getConnection();

            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = staff.Id;
                cmd.Parameters.Add("@tenNhanVien", SqlDbType.NVarChar).Value = staff.TenNhanVien;
                cmd.Parameters.Add("@tuoi", SqlDbType.Int).Value = staff.Tuoi;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = staff.Sodt;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = staff.Username;


                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                    return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }
    }
}
