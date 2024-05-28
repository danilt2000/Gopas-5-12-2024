namespace CommandDemo
{
    public class CommandFactory : ICommandFactory
    {
        private readonly ICalc calc;

        public CommandFactory(ICalc calc)
        {
            this.calc = calc;
        }

        public PlusCommand CreatePlusCommand()
        {
            return new PlusCommand() { Reciever = calc };
        }

        public GetResultCommand CreateGetResultCommand()
        {
            return new GetResultCommand() { Reciever = calc };
        }
    }
}
