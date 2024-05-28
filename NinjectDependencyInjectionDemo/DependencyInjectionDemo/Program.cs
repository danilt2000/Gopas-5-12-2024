using DependencyInjectionDemo;
using Ninject;

// manual

Console.WriteLine("Manual");

var ss = new SharedService();
var s1 = new Service1(ss);
var s2 = new Service2(ss);
var c = new Client(s1, s2);

c.UseServices();

Console.WriteLine("IoCC");
var iocc = new DemoIoCC();
var c2 = iocc.Get<Client>();

c2.UseServices();