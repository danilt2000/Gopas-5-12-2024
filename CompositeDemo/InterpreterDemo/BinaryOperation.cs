
namespace InterpreterDemo
{
    public abstract class BinaryOperation : IExpression
    {
        protected readonly IExpression left;
        protected readonly IExpression right;

        protected BinaryOperation(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public abstract int Interpret(IDictionary<string, int> context);
    }
}
