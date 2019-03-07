using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
namespace RabbitMQListener
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.UserName = "sa";
            factory.Password = "eloi1!";
            factory.HostName = "127.0.0.1";
            factory.Port = 5672;

            IConnection conn = factory.CreateConnection();
            IModel channel = conn.CreateModel();
            byte[] messageBodyBytes = System.Text.Encoding.UTF8.GetBytes("Hello, world!");
            channel.BasicPublish("AMQP default", "33", null, messageBodyBytes);
        }
    }
}
