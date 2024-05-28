namespace InterpreterDemo
{
    public class Literal : IExpression
    {
        private readonly int _value;

        public Literal(int value)
        {
            _value = value;
        }

        public int Interpret(IDictionary<string, int> context)
        {
            return _value;
        }
    }
}
