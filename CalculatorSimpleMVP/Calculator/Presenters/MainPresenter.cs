using Calculator.Models;

namespace Calculator.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private ICalc model;

        public IView<MainViewData> MainView { get; set; }

        public MainPresenter(ICalc model)
        {
            this.model = model;
        }

        public void PlusAction(string input)
        {
            var doubleInput = double.Parse(input);
            model.Plus(doubleInput);

            MainView.UpdateView(new MainViewData(model.Result));
        }
    }
}
