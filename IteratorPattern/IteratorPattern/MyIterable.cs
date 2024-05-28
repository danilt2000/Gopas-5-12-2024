using System.Collections;

class MyIterable : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        return new MyIterator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
