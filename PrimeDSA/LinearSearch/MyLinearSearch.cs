namespace PrimeDSA.LinearSearch;

public class MyLinearSearch
{
    private readonly int[] _hayStack;
    private readonly int _needle;

    public MyLinearSearch(int[] hayStack, int needle)
    {
        _hayStack = hayStack;
        _needle = needle;
    }
    public bool Search()
    {
        for (int i = 0; i < _hayStack.Length; i++)
        {
            if (_needle == _hayStack[i])
            {
                return true;
            }
        }
        return false;
    }
}
