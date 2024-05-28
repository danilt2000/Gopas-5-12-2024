
namespace CommandProcessorDemo
{
    public interface ILog
    {
        IEnumerable<string> Items { get; }

        void RemoveLastMessage();
        void Write(string message);
    }
}