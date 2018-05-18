using Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDatabase
    {
        List<User> GetAllUsers();
        List<string> GetAllUsersWithConversation();
        User CheckUserAndPasswordForLogin(string userName, string password);
    }
}
