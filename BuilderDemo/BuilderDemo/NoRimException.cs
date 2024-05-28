using System.Runtime.Serialization;

namespace BuilderDemo
{
    [Serializable]
    internal class NoRimException : Exception
    {
        public NoRimException()
        {
        }

        public NoRimException(string? message) : base(message)
        {
        }

        public NoRimException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoRimException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}