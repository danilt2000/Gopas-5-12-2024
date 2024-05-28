using CommandDemo;

ICalc calc = new Calc();    
CommandFactory commandFactory = new CommandFactory(calc);

// decide what to do
var plus1 = commandFactory.CreatePlusCommand();
var plus2 = commandFactory.CreatePlusCommand();
var getResult = commandFactory.CreateGetResultCommand();

// decide param values
plus1.X = 1;
plus2.X = 2;

// decide when
var invoker = new Invoker();
invoker.Execute(plus1);
invoker.Execute(plus2);
invoker.Execute(getResult);

// process resuls
Console.WriteLine(getResult.Result);