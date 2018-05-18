using Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public interface IChatBusiness
    {
        List<User> GetListUsers();
        List<string> GetAllUsersWithConversation();
        string GetCurrentUserName();
        string SendMessage(string message, string nameQueue);
        string ReceiveMessage(string nameQueue);
    }
}
