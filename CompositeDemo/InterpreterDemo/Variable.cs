
namespace InterpreterDemo
{
    public class Variable : IExpression
    {
        private readonly string name;

        public Variable(string name)
        {
            this.name = name;
        }

        public int Interpret(IDictionary<string, int> context)
        {
            return context[name];
        }
    }
}
