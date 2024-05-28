namespace CommandProcessorDemo
{
    public interface ICalc
    {
        double Result { get; }

        void Minus(double x);
        void Plus(double x);
    }
}