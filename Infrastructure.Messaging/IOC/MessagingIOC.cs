using Infrastructure.Messaging.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Messaging.IOC
{
    public static class MessagingIOC
    {
        public static void AddMessagingServices(this IServiceCollection services)
        {
            var serviceFlag = "RabbitMQ";
            switch (serviceFlag)
            {
                case "RabbitMQ":
                    services.AddSingleton<IMessageBrokerService>(ctx =>
                    {
                        return new RabbitMQMessageBrokerService();
                    });
                    break;
                default:
                    break;
            }
        }
    }
}
