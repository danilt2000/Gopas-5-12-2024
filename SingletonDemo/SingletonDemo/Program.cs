
using SingletonDemo;

var c1 = Config.Instance;
var c2 = Config.Instance;
Console.WriteLine(c1 == c2);

