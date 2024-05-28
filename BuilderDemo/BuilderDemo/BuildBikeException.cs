using System.Runtime.Serialization;

namespace BuilderDemo
{
    [Serializable]
    internal class BuildBikeException : Exception
    {
        public BuildBikeException() 
        {
        }

        public BuildBikeException(Exception e): base("Build bike failed. See inner exception for details.", e)
        {
            
        }

        public BuildBikeException(string? message) : base(message)
        {
        }

        public BuildBikeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BuildBikeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}