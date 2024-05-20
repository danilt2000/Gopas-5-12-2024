using PrototypeDemo;

var prototype = new ClassWithExpensiveConstructor();
var clone1 = (ClassWithExpensiveConstructor)prototype.Clone();
var clone2 = (ClassWithExpensiveConstructor)prototype.Clone();
Console.WriteLine(clone1 == clone2);