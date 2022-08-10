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
    public class AccountDAL
    {
        SqlConnection conn = null;
        SqlDataAdapter adapter;
        SqlCommand cmd;

        public bool Command(Account account, string query)
        {
            conn = Connection.getConnection();

            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = account.Username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = account.Password;
                cmd.Parameters.Add("@typeUser", SqlDbType.NVarChar).Value = account.TypeUser;
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

        
        public DataTable Select(string query)
        {
            conn = Connection.getConnection();
            

            conn.Open();
            DataTable dt = new DataTable();

            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            return dt;
        }


    }
}
