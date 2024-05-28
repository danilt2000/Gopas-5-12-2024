List<int> l = new() { 1, 2, 3, 4 };

var iterator = l.GetEnumerator();
while (iterator.MoveNext())
{
    Console.WriteLine(iterator.Current);
}

foreach (int i in l) Console.WriteLine(i);

var iterable = new MyIterable();    
foreach (string s in iterable) {  Console.WriteLine(s); }