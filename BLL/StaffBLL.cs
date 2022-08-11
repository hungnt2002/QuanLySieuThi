using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;
using BLL;

namespace BLL
{
    public class StaffBLL
    {
        public bool insert(string id, string tenNV, string tuoi, string sodt, string username, string password)
        {

            RegisterBLL registerBLL = new RegisterBLL();
            if (!registerBLL.regiterAccount(tenNV, password))
            {
                return false;
            }
            Staff staff = new Staff(id, tenNV, tuoi, sodt);
            string query = "INSERT INTO tblStaff VALUES(@tenNV, @tuoi, @SDT)";
            StaffDAL staffDAL = new StaffDAL();
            staffDAL.Command(staff, query);


            return true;
        }

        public bool update(string id, string tenNV, string tuoi, string sodt, string username, string password)
        {
            Staff staff = new Staff(id, tenNV, tuoi, sodt);
            string query = "UPDATE tblStaff" +
                " SET tenNV = @tenNV, tuoi = @tuoi, SDT = @SDT" +
                " WHERE idNV = @idNV";
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
            Account account = new Account(username, "", "");
            Staff staff = new Staff("id", "", "", "");
            string query = "DELETE FROM tblAccount WHERE username = @username";
            AccountDAL accountDAL = new AccountDAL();
            if (!accountDAL.Command(account, query))
            {
                return false;
            }

            query = "DELETE FROM tblStaff WHERE id = @id";
            StaffDAL staffDAL = new StaffDAL();
            if (!staffDAL.Command(staff, query))
            {
                return false;
            }

            return true;
        }

        public DataTable loadAll()
        {
            QuerySelect querySelect = new QuerySelect();
            string query = "SELECT * FROM tblStaff";
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
    }
}
