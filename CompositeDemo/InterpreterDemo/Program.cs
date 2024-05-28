using InterpreterDemo;

IExpression expression = 
    new Addition(
        new Multiplication(
            new Literal(3),
            new Variable("x")
        ), 
            new Variable("y")
    );

Console.WriteLine(expression.Interpret(new Dictionary<string, int>() {
    {"x", 1},
    {"y", 2}
}));

Console.WriteLine(expression.Interpret(new Dictionary<string, int>() {
    {"x", 3},
    {"y", 4}
}));