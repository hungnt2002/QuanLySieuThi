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
        AccountDAL accountDAL; 
        public bool checkAccount(string username, string password)
        {
            accountDAL = new AccountDAL();
            DataTable dataTable = accountDAL.SelectAll();
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                //if (username.Equals(dataTable.Rows[i][1].ToString().Trim()) && password.Equals(dataTable.Rows[i][2].ToString().Trim()))
                if (username.Equals(dataTable.Rows[i][1]) && password.Equals(dataTable.Rows[i][2]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
