using CarTrader.Services.Workflow.Application.Interfaces.Services;
using CarTrader.Services.Workflow.Application.Messages;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CarTrader.Services.Workflow.Application.Services
{
    public class MessagingBackgroundService : BackgroundService
    {
        private readonly IMessageSubscriber _messageSubscriber;
        private readonly ILogger<MessagingBackgroundService> _logger;

        public MessagingBackgroundService(
            IMessageSubscriber messageSubscriber,
            ILogger<MessagingBackgroundService> logger
            )
        {
            _messageSubscriber = messageSubscriber;
            _logger = logger;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                $"Background Messaging service '{nameof(MessagingBackgroundService)}' is running");

            _messageSubscriber
                .SubscribeMessage<CreateCarMessage>("cartrader-cars-queue", "CarTrader.Cars", "cars",
                    async (msg) => {
                        _logger.LogInformation($"Recieved message {msg}");
                        await Task.CompletedTask;
                    }
                );

            return Task.CompletedTask;
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                $"Background Messaging service '{nameof(MessagingBackgroundService)}' is stopping.");

            await base.StopAsync(cancellationToken);
        }
    }
}
