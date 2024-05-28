
namespace InterpreterDemo
{
    public class Addition : BinaryOperation
    {
        public Addition(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override int Interpret(IDictionary<string, int> context)
        {
            return left.Interpret(context) + right.Interpret(context);
        }
    }
}
