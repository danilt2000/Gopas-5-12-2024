namespace InterpreterDemo
{
    public interface IExpression
    {
        public TypedValue Interpret(IDictionary<string, TypedValue> context);
    }
}
