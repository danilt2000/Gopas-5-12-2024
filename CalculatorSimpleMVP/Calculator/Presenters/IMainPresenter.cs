namespace Calculator.Presenters
{
    public interface IMainPresenter
    {
        IView<MainViewData> MainView { get; set; }

        void PlusAction(string input);
    }
}