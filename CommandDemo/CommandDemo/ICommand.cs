namespace CommandDemo
{
    public interface ICommand
    {
        void Execute();
    }
    public interface ICommand<T>: ICommand
    {
        public T? Reciever { get; set; }
        
    }
}
