using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using DTO;
namespace BLL
{
    public class TestAccountDAL
    {


        public static bool insert()
        {
            Account account = new Account("0007", "1000", "User");
            AccountDAL accountDAL = new AccountDAL();
            string query = "insert into tblAccount values(@username, @password, @typeUser)";
            //string query = "Delete From tblAccount Where username = @username";


            bool check = accountDAL.Command(account, query);
            return check;
        }

    } 
}
