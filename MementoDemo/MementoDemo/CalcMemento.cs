namespace MementoDemo
{
    internal partial class Calc
    {
        private class CalcMemento(double result)
        {
            public double Result => result;
        }
    }
}
