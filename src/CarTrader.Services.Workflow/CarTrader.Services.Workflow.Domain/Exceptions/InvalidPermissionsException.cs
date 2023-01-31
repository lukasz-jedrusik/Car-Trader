using System.Runtime.Serialization;

namespace CarTrader.Services.Workflow.Domain.Exceptions
{
    [Serializable]
    public class InvalidPermissionsException : CarTrader.Services.WorkflowException
    {
        public InvalidPermissionsException() : base("Invalid Permissions, Access denied")
        {
        }

        protected InvalidPermissionsException(string message) : base(message)
        {
        }

        protected InvalidPermissionsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }

        protected InvalidPermissionsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}