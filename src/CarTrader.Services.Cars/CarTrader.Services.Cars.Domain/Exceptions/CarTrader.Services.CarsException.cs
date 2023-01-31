using System.Runtime.Serialization;

namespace CarTrader.Services.Cars.Domain.Exceptions
{
    [Serializable]
    public abstract class CarTrader.Services.CarsException : Exception
    {
        protected CarTrader.Services.CarsException() {}

        protected CarTrader.Services.CarsException(string message) : base(message)
        {
        }

        protected CarTrader.Services.CarsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }

        protected CarTrader.Services.CarsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}