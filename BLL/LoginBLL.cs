using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class LoginBLL
    {
        
        public string checkAccount(string username, string password)
        {
            QuerySelect querySelect = new QuerySelect();
            string query = "select * from tblAccount";
            DataTable dataTable = querySelect.Select(query);
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                
                if (username.Equals(dataTable.Rows[i][1]) && password.Equals(dataTable.Rows[i][2]))
                {
                    return dataTable.Rows[i][3].ToString();
                }
            }
            return "";
        }

    }
}
