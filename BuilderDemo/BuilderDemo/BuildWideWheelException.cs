using System.Runtime.Serialization;

namespace BuilderDemo
{
    [Serializable]
    internal class BuildWideWheelException : Exception
    {
        private Exception ex;

        public BuildWideWheelException()
        {
        }

        public BuildWideWheelException(Exception ex)
        {
            this.ex = ex;
        }

        public BuildWideWheelException(string? message) : base(message)
        {
        }

        public BuildWideWheelException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BuildWideWheelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}