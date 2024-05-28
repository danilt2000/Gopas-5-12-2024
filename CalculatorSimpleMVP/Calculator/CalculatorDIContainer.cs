using Calculator.Models;
using Calculator.Presenters;
using Ninject;

namespace Calculator
{
    public class CalculatorDIContainer : StandardKernel
    {
        public CalculatorDIContainer()
        {
            
            // models
            Bind<ICalc>().To<Calc>().InSingletonScope();

            //presenters
            Bind<IMainPresenter>().To<MainPresenter>();
            
        }
    }
}
