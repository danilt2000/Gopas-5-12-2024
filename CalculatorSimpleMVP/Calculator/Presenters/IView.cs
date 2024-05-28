namespace Calculator.Presenters
{
    public interface IView<T>
    {
        void UpdateView(T viewData);
    }
}