namespace CarTrader.Services.Workflow.Application.Messages;

public record CreateCarMessage(Guid CarId, string BussinesKey) : IMessage;