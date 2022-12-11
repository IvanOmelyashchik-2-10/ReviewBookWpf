using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewBookWpf.Services.DataBase
{
    internal class User
    {
        private int id { get; set; }
        private string login, email, pass;
        public User(string login, string email, string pass)
        {
           
            this.login = login;
            this.email = email;
            this.pass = pass;
        }
    }
}
