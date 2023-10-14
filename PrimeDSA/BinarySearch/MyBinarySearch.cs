namespace PrimeDSA.BinarySearch;

public class MyBinarySearch
{
    private readonly int[] _hayStack;
    private readonly int _needle;

    public MyBinarySearch(int[] hayStack, int needle)
    {
        _hayStack = hayStack;
        _needle = needle;
    }
    public bool Search()
    {
        var lo = 0;
        var hi = _hayStack.Length;

        do
        {
            var mid = (int)Math.Floor((double)(lo + (hi - lo) / 2));
            var midVal = _hayStack[mid];

            if (_needle == midVal)
            {
                return true;
            }
            else if (_needle > midVal)
            {
                lo = mid + 1;
            }
            else
            {
                hi = mid;
            }
        }
        while (lo < hi);

        return false;
    }
}
