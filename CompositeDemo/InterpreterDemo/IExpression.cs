namespace InterpreterDemo
{
    public interface IExpression
    {
        public int Interpret(IDictionary<string, int> context);
    }
}
