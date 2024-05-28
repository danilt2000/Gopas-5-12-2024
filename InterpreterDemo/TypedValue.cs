namespace InterpreterDemo
{
    public class TypedValue
    {
        public TypedValue(object value, string type)
        {
            Value = value;
            Type = type;
        }

        public object Value { get; set; }
        public string Type { get; init; }

        public override string ToString() => $"{Type} {Value}";
    }
}