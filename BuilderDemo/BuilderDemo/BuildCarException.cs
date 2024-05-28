using System.Runtime.Serialization;

namespace BuilderDemo
{
    [Serializable]
    internal class BuildCarException : Exception
    {
        private Exception e;

        public BuildCarException()
        {
        }

        public BuildCarException(Exception e)
        {
            this.e = e;
        }

        public BuildCarException(string? message) : base(message)
        {
        }

        public BuildCarException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BuildCarException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}