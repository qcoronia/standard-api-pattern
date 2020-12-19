using System;
using System.Threading.Tasks;
using Infrastructure.Messaging.Models.Interfaces;

namespace Infrastructure.Messaging.Services
{
    public class RabbitMQMessageBrokerService : IMessageBrokerService
    {
        public Task Listen(string queue, Action<IMessageObject> action)
        {
            throw new NotImplementedException();
        }

        public Task Send(string queue, string message)
        {
            throw new NotImplementedException();
        }
    }
}
