namespace CommandProcessorDemo
{
    public class CommandProcessor
    {
        private Stack<ICommand> compensationStack = new Stack<ICommand>();
        public void Execute(ICommand command) { 
            command.Execute();
            if(command.IsCompensabe)
                compensationStack.Push(command);
        }

        public void CompensateLast() { 
            if(compensationStack.Count > 0)
                compensationStack.Pop().Compensate();
        }

    }
}
