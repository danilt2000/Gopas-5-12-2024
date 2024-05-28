using System.Runtime.Serialization;

namespace BuilderDemo
{
    [Serializable]
    internal class SlimTireBuildException : Exception
    {
        private Exception e;

        public SlimTireBuildException()
        {
        }

        public SlimTireBuildException(Exception e)
        {
            this.e = e;
        }

        public SlimTireBuildException(string? message) : base(message)
        {
        }

        public SlimTireBuildException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SlimTireBuildException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}