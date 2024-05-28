using MementoDemo;

var calc = new Calc();
Console.WriteLine(calc.Result);

calc.Plus(1);
Console.WriteLine(calc.Result);

calc.Plus(2);
Console.WriteLine(calc.Result);

calc.Undo();
Console.WriteLine(calc.Result);

calc.Undo();
Console.WriteLine(calc.Result);

calc.Undo();
Console.WriteLine(calc.Result);