using Data.Repository.Scope.Aggregate;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Repository.IOC
{
    public static class RepositoryIOC
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IAggregateRepository, AggregateRepository>();
        }
    }
}
