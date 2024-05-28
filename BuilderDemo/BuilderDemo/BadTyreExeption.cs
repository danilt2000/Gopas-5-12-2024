using System.Runtime.Serialization;

namespace BuilderDemo
{
    [Serializable]
    internal class BadTyreExeption : Exception
    {
        public BadTyreExeption()
        {
        }

        public BadTyreExeption(string? message) : base(message)
        {
        }

        public BadTyreExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BadTyreExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}