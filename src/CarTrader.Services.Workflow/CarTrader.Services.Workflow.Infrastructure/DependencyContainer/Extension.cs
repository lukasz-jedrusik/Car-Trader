using Microsoft.Extensions.DependencyInjection;
using CarTrader.Services.Workflow.Application.Services;
using CarTrader.Services.Workflow.Application.Interfaces.Services;
using CarTrader.Services.Workflow.Infrastructure.Services;

namespace CarTrader.Services.Workflow.Infrastructure.DependencyContainer
{
    public static class Extension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Repositories

            // Services 
            services.AddSingleton<IMessageSubscriber, MessageSubscriber>();
            services.AddHostedService<MessagingBackgroundService>();

            // Queue
            services.AddHostedService<QueuedHostedService>();
            services.AddSingleton<IBackgroundTaskQueue>(_ =>
            {
                const int queueCapacity = 100;
                return new BackgroundTaskQueue(queueCapacity);
            });

            return services;
        }
    }
}