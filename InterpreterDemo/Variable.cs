
namespace InterpreterDemo
{
    public class Variable : IExpression
    {
        private readonly string name;

        public Variable(string name)
        {
            this.name = name;
        }

        public TypedValue Interpret(IDictionary<string, TypedValue> context)
        {
            var typedValue = context[name];
            if (typedValue.Type == "int" && typedValue.GetType().IsAssignableFrom(typeof(int))) throw new Exception();
            if (typedValue.Type == "float" && typedValue.GetType().IsAssignableFrom(typeof(int))) throw new Exception();
            return typedValue;
        }
    }
}
