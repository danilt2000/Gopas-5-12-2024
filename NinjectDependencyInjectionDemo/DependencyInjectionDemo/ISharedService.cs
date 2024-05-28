namespace DependencyInjectionDemo
{
    public interface ISharedService
    {
        int Count { get; }

        void Increase();
    }
}