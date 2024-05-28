using System.Runtime.Serialization;

namespace BuilderDemo
{
    [Serializable]
    internal class BuildSlimWheelException : Exception
    {
        private Exception ex;

        public BuildSlimWheelException()
        {
        }

        public BuildSlimWheelException(Exception ex)
        {
            this.ex = ex;
        }

        public BuildSlimWheelException(string? message) : base(message)
        {
        }

        public BuildSlimWheelException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BuildSlimWheelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}