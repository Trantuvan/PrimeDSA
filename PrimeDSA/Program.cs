using PrimeDSA.MergeSort;

namespace PrimeDSA;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 9, 3, 7, 4, 69, 420, 42 };

        MyMergeSort mergeSort = new();
        var sortedArr = mergeSort.Sort(numbers);
        var sortedStr = string.Join(", ", sortedArr);

        Console.WriteLine($"sorted array: {sortedStr}");
    }
}