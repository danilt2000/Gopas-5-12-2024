namespace CommandDemo
{
    public class GetResultCommand : ICommand<ICalc>
    {
        public ICalc? Reciever { get; set; }

        public double? Result { get; private set; }

        public void Execute()
        {
            Result = Reciever?.Result;
        }
    }
}
