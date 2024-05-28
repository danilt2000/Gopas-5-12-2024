using ProxyAndDecoratorDemo;

var calc = new RoundingProxy(new NoPlusOnFridayProxy(new LoggingDecorator(new Calc())));
var cc = new Client(calc);
cc.UseCalc();