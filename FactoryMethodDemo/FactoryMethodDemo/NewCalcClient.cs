namespace OpenCloseDemo
{
    public class NewCalcClient : CalcClient
    {
        protected override Calc CreateCalc()
        {
            return new NewCalc();
        }
    }
}
