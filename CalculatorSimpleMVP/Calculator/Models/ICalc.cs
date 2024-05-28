namespace Calculator.Models
{
    public interface ICalc
    {
        double Result { get; }

        void Plus(double x);
    }
}