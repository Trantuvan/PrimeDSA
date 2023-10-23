namespace PrimeDSA.QuickSort;

public class MyQuickSort
{
    private readonly int[] _arr;

    public MyQuickSort(int[] arr)
    {
        _arr = arr;
    }

    public int[] Sort()
    {
        Qs(_arr, 0, _arr.Length - 1);
        return _arr;
    }

    private void Qs(int[] array, int lo, int hi)
    {
        if (lo >= hi)
        {
            return;
        }

        //* pre-recurse
        var pivotIdx = Partition(array, lo, hi);
        //* recurse - lower pivot idx
        Qs(array, lo, pivotIdx - 1);
        //* post recurse of lower pivot idx - recurse upper pivot idx
        Qs(array, pivotIdx + 1, hi);
    }

    private int Partition(int[] array, int lo, int hi)
    {
        var pivot = array[hi];
        var idx = lo - 1;

        for (int i = lo; i < hi; i++)
        {
            if (array[i] <= pivot)
            {
                idx++;
                (array[i], array[idx]) = (array[idx], array[i]);
            }
        }

        idx++;
        (array[hi], array[idx]) = (array[idx], pivot);

        return idx;
    }
}
