using CommandProcessorDemo;

var calc = new Calc();
var log = new Log();
var facade = new Facade(calc, log);
var plus1 = new PlusCommand() { Reciever = facade, X = 1 };
var plus2 = new PlusCommand() { Reciever = facade, X = 2 };

var commandProcessor = new CommandProcessor();

Console.WriteLine(calc.Result);
Console.WriteLine(log.Items.Aggregate("", (p, c) => p + c + " | "));
Console.WriteLine("----------");

commandProcessor.Execute(plus1);
Console.WriteLine(calc.Result);
Console.WriteLine(log.Items.Aggregate("", (p,c) => p + c + " | "));
Console.WriteLine("----------");

commandProcessor.Execute(plus2);
Console.WriteLine(calc.Result);
Console.WriteLine(log.Items.Aggregate("", (p, c) => p + c + " | "));
Console.WriteLine("----------");

commandProcessor.CompensateLast();
Console.WriteLine(calc.Result);
Console.WriteLine(log.Items.Aggregate("", (p, c) => p + c + " | "));
Console.WriteLine("----------");

commandProcessor.CompensateLast();
Console.WriteLine(calc.Result);
Console.WriteLine(log.Items.Aggregate("", (p, c) => p + c + " | "));
Console.WriteLine("----------");
