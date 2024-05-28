
namespace InterpreterDemo
{
    public class Addition : BinaryOperation
    {
        public Addition(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override TypedValue Interpret(IDictionary<string, TypedValue> context)
        {
            var leftValue = left.Interpret(context);
            var rightValue = right.Interpret(context);
            if (leftValue.Type == "int" && rightValue.Type == "int") 
                return new TypedValue((int)leftValue.Value + (int)rightValue.Value, "int");
            return new TypedValue(Double.Parse(leftValue.Value.ToString()) + Double.Parse(rightValue.Value.ToString()), "float");
        }
    }
}
