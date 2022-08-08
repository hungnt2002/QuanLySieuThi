using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AccountDAL
    {
        string query;
        SqlConnection conn = null;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public bool Insert(Account t)
        {
            
            //throw new NotImplementedException();
            conn = Connection.getConnection();
            query = "insert into tblAccount values (@username, @password, @typeUser)";

            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = t.Username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = t.Password;
                cmd.Parameters.Add("@typeUser", SqlDbType.NVarChar).Value = t.TypeUser;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //ex.ToString();
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public DataTable SelectAll()
        {
            conn = Connection.getConnection ();
            query = "Select * from tblAccount";

            conn.Open();
            DataTable dt = new DataTable();

            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            return dt;
        }

  
    }
}
