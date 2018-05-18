using Common.Logic;
using Common.Logic.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Business.Logic
{
    public class ChatBusiness: IChatBusiness
    {
        private Repository repository;
        private RabbitMQ rabbitMQ;

        public ChatBusiness()
        {
            this.repository = new Repository();
            this.rabbitMQ = new RabbitMQ();
        }

        public List<User> GetListUsers()
        {
            return this.repository.GetAllUsers();
        }
        public List<string> GetAllUsersWithConversation()
        {
            return this.repository.GetAllUsersWithConversation();
        }

        public string GetCurrentUserName()
        {
            return Configuration.ReadValueFromAppConfig("currentUser");
        }

        public string SendMessage(string message, string nameQueue)
        {
            return this.rabbitMQ.Send(message, nameQueue);
        }

        public string ReceiveMessage(string nameQueue)
        {
            return this.rabbitMQ.Receive(nameQueue);
        }

        
    }
}
