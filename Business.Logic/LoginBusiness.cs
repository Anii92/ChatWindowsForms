using Common.Logic.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class LoginBusiness: ILoginBusiness
    {
        private Repository repository;

        public LoginBusiness()
        {
            this.repository = new Repository();
        }

        public User Login(string userName, string password)
        {
            User user = this.repository.CheckUserAndPasswordForLogin(userName, password);
            if (user.Userid > 0)
            {
                this.SaveCurrentUser(user.Email);
            }
            return user;
        }

        private void SaveCurrentUser(string value)
        {
            Common.Logic.Configuration.SaveValueToAppConfig("currentUser", value);
        }
    }
}
