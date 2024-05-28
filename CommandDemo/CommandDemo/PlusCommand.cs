namespace CommandDemo
{
    public class PlusCommand : ICommand<ICalc>
    {
        public ICalc? Reciever { get; set; }
        public double X { get; set; }

        public void Execute()
        {
            Reciever?.Plus(X);
        }
    }
}
