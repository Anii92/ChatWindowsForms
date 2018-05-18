using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class RabbitMQ
    {
        public RabbitMQ()
        {

        }

        public IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = "192.168.99.100";
            factory.VirtualHost = "/";
            return factory.CreateConnection();
        }

        public string Send(string message, string nameQueue)
        {
                using (var connection = this.GetConnection())
                {
                    using (var channel = connection.CreateModel())
                    {
                        channel.QueueDeclare(queue: nameQueue,
                                             durable: true,
                                             exclusive: false,
                                             autoDelete: false,
                                             arguments: null);
                        var body = Encoding.UTF8.GetBytes(message);

                        channel.BasicPublish(exchange: "",
                                             routingKey: nameQueue,
                                             basicProperties: null,
                                             body: body);
                        //IModel channel = connection.CreateModel();
                        //channel.ExchangeDeclare("messageexchange", ExchangeType.Direct);
                        //channel.QueueDeclare(friendqueue, true, false, false, null);
                        //channel.QueueBind(friendqueue, "messageexchange", friendqueue, null);
                        //var msg = Encoding.UTF8.GetBytes(message);
                        //channel.BasicPublish("messageexchange", friendqueue, null, msg);
                    }
                }
            return message;
        }

        public string Receive(string nameQueue)
        {
            string message = "";
            using (var connection = this.GetConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: nameQueue,
                                         durable: true,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);
                    BasicGetResult result = channel.BasicGet(queue: nameQueue, autoAck: true);
                    message = result != null ? Encoding.UTF8.GetString(result.Body) : "";
                }
            }
            return message;
            //string queue = myqueue;
            //IModel channel = con.CreateModel();
            //channel.QueueDeclare(queue: queue, durable: true, exclusive: false, autoDelete: false, arguments: null);
            //var consumer = new EventingBasicConsumer(channel);
            //BasicGetResult result = channel.BasicGet(queue: queue, autoAck: true);
            //if (result != null)
            //    return Encoding.UTF8.GetString(result.Body);
            //else
            //    return null;
        }
    }
}
