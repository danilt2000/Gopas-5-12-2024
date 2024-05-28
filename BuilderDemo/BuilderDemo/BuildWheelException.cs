using System.Runtime.Serialization;

namespace BuilderDemo
{
    [Serializable]
    internal class BuildWheelException : Exception
    {
        private Exception ex;

        public BuildWheelException()
        {
        }

        public BuildWheelException(Exception ex)
        {
            this.ex = ex;
        }

        public BuildWheelException(string? message) : base(message)
        {
        }

        public BuildWheelException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BuildWheelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}