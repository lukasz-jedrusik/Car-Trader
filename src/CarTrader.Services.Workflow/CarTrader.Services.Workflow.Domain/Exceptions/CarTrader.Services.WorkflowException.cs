using System.Runtime.Serialization;

namespace CarTrader.Services.Workflow.Domain.Exceptions
{
    [Serializable]
    public abstract class CarTrader.Services.WorkflowException : Exception
    {
        protected CarTrader.Services.WorkflowException() {}

        protected CarTrader.Services.WorkflowException(string message) : base(message)
        {
        }

        protected CarTrader.Services.WorkflowException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }

        protected CarTrader.Services.WorkflowException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}