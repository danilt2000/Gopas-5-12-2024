namespace InterpreterDemo
{
    public class Literal : IExpression
    {
        private readonly TypedValue _value;

        public Literal(TypedValue value)
        {
            _value = value;
        }

        public TypedValue Interpret(IDictionary<string, TypedValue> context)
        {
            return _value;
        }
    }
}
