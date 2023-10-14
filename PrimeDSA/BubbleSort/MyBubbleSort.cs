namespace PrimeDSA.BubbleSort;

public class MyBubbleSort
{
    private readonly int[] _arr;

    public MyBubbleSort(int[] arr)
    {
        _arr = arr;
    }

    public void Sort()
    {
        for (int i = 0; i < _arr.Length; i++)
        {
            for (int j = 0; j < _arr.Length - 1 - i; j++)
            {
                if (_arr[j] > _arr[j + 1])
                {
                    //* Use tuple to swap value
                    (_arr[j + 1], _arr[j]) = (_arr[j], _arr[j + 1]);
                }
            }
        }
    }
}
