using InterpreterDemo;

IExpression expression = 
    new Addition(
        new Multiplication(
            new Literal(new TypedValue(3, "int")),
            new Variable("x")
        ), 
            new Variable("y")
    );

Console.WriteLine(expression.Interpret(new Dictionary<string, TypedValue>() {
    {"x", new TypedValue(1, "int") },
    {"y", new TypedValue(2, "int")}
}));

Console.WriteLine(expression.Interpret(new Dictionary<string, TypedValue>() {
    {"x", new TypedValue(3, "int") },
    {"y", new TypedValue(4.1, "float")}
}));