using Directory = CompositeDemo.Directory;
using File = CompositeDemo.File;

var root = new Directory("""\""");
var dirA = new Directory("A");
var dirB = new Directory("B");
var f = new File("f.txt");

root.Children.Add(dirA);
root.Children.Add(dirB);
dirA.Children.Add(f);

dirA.Delete();
Console.WriteLine(f.Deleted);