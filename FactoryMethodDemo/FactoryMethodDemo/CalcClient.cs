namespace OpenCloseDemo
{
    public class CalcClient
    {
        public CalcClient()
        {
            Console.WriteLine("Calc created");
        }

        protected virtual Calc CreateCalc() { return new Calc(); }
        public void UseCalc()
        {
            var calc = CreateCalc();
            calc.Plus(1);
            calc.Plus(2);
            Console.WriteLine(calc.Result);
        }
    }
}
