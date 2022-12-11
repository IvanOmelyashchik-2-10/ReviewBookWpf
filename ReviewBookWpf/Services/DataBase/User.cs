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
        public int ID { get; set; }
        public string login { get; set; }
        public  string pass { get; set; }
        public  string email { get; set; }
      
        

       


        public User(string login, string pass, string email)
        {

            this.login = login;
            this.pass = pass;
            this.email = email;
        }

        public User(){}
    }
}
