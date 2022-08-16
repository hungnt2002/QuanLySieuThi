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

    public class QuerySelect
    {

        private SqlConnection conn = null;
        private SqlDataAdapter adapter;
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
