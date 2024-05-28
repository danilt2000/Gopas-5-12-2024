namespace InterpreterDemo
{
    public class Multiplication : BinaryOperation
    {
        public Multiplication(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override TypedValue Interpret(IDictionary<string, TypedValue> context)
        {
            var leftValue = left.Interpret(context);
            var rightValue = right.Interpret(context);
            if (leftValue.Type == "int" && rightValue.Type == "int")
                return new TypedValue((int)leftValue.Value * (int)rightValue.Value, "int");
            return new TypedValue((double)leftValue.Value * (double)rightValue.Value, "float");
        }
    }
}
