namespace OpenCloseDemo
{
    public class NewCalc : Calc
    {
        public override void Plus(double x)
        {
            Result += x + 1;
        }
    }
}
