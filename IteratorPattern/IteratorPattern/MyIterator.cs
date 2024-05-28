using System.Collections;

class MyIterator : IEnumerator<string>
{
    private int i = -1;

    private string[] s = {"a","b","c"};
    public string Current => s[i];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        i++;
        return i != s.Length;
    }

    public void Reset()
    {
        i = -1;
    }
}
