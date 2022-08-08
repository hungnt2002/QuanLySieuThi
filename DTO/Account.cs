using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string username;
        private string password;
        private string typeUser;

        public Account()
        {
        }

        public Account(string username, string password, string typeUser)
        {
            this.username = username;
            this.password = password;
            this.typeUser = typeUser;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string TypeUser { get => typeUser; set => typeUser = value; }
    }
}
