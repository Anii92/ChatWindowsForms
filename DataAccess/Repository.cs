using Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Repository
    {
        private IDatabase database;

        public Repository()
        {
            this.database = new Database();
        }

        public List<string> GetAllUsersWithConversation()
        {
            return this.database.GetAllUsersWithConversation();
        }

        public List<User> GetAllUsers()
        {
            return this.database.GetAllUsers();
        }

        public User CheckUserAndPasswordForLogin(string userName, string password)
        {
            return this.database.CheckUserAndPasswordForLogin(userName, password);
        }
    }
}
