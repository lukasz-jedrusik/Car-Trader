using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CarTrader.Services.Workflow.Infrastructure.Extensions.MediatR
{
    public static class Extension
    {
        public static IServiceCollection AddMediatR(this IServiceCollection services)
        {
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}