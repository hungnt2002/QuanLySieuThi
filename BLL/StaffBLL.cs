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
    public class StaffBLL
    {
        public bool insert(string tenNhanVien, string tuoi, string sodt, string username, string password)
        {

            RegisterBLL registerBLL = new RegisterBLL();
            if (!registerBLL.checkAccount(username, password))
            {
                return false;
            }
            Staff staff = new Staff("1", tenNhanVien, tuoi, sodt, username);
            string query = "INSERT INTO tblStaff VALUES(@tenNhanVien, @tuoi, @SDT, @username)";
            StaffDAL staffDAL = new StaffDAL();
            if(!staffDAL.Command(staff, query))
            {
                registerBLL.deleteAccount(username);
                return false;
            }


            return true;
        }

        public bool update(string id, string tenNhanVien, string tuoi, string sodt, string username, string password)
        {
            Staff staff = new Staff(id, tenNhanVien, tuoi, sodt, username);
            string query = "UPDATE tblStaff" +
                " SET tenNhanVien = @tenNhanVien, tuoi = @tuoi, SDT = @SDT" +
                " WHERE id = @id";
            StaffDAL staffDAL = new StaffDAL();
            if (staffDAL.Command(staff, query))
            {
                RegisterBLL registerBLL = new RegisterBLL();
                registerBLL.updateAccount(username, password);
                return true;
            }

            return false;
        }

        public bool delete(string id, string username)
        {
           
            string query = "DELETE FROM tblAccount WHERE username = @username";
            Account account = new Account(username, "", "");
            AccountDAL accountDAL = new AccountDAL();
            if(!accountDAL.Command(account, query))
            {
                return false;
            }

            return true;
        }

        public DataTable loadAll()
        {
            QuerySelect querySelect = new QuerySelect();
            string query = "SELECT tblStaff.*, tblAccount.password FROM tblStaff, tblAccount WHERE tblStaff.username = tblAccount.username";
            DataTable dataTable = querySelect.Select(query);
            return dataTable;
        }

        public DataTable selectCondition(string tenNV)
        {
            QuerySelect querySelect = new QuerySelect();
            string query = "SELECT * FROM tblStaff WHERE tenNV like N'%" + tenNV + "%'";
            DataTable dataTable = querySelect.Select(query);
            return dataTable;

        }

        public DataTable selectTenNV(string username)
        {
            QuerySelect querySelect = new QuerySelect();
            string query = "SELECT tenNhanVien FROM tblStaff WHERE username = '" + username + "'";
            DataTable dataTable = querySelect.Select(query);
            return dataTable;
        }
    }
}
