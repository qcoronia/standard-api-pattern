using System;
using System.Threading.Tasks;
using Infrastructure.Messaging.Models.Interfaces;

namespace Infrastructure.Messaging.Services
{
    public interface IMessageBrokerService
    {
        Task Listen(string queue, Action<IMessageObject> action);

        Task Send(string queue, string message);
    }
}
