using PrimeDSA.QuickSort;

namespace PrimeDSA;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 9, 3, 7, 4, 69, 420, 42 };

        MyQuickSort quickSort = new(numbers);
        var sortedArr = quickSort.Sort();
        var sortedStr = string.Join(", ", sortedArr);

        Console.WriteLine($"sorted array: {sortedStr}");
    }
}