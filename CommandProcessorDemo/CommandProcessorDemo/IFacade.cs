
namespace CommandProcessorDemo
{
    public interface IFacade
    {
        IEnumerable<string> LogItems { get; }
        double Result { get; }

        void Minus(double x);
        void Plus(double x);
        void RemoveLastLogMessage();
    }
}