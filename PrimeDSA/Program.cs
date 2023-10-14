using PrimeDSA.BubbleSort;

namespace PrimeDSA;

public class Program
{
    public static void Main()
    {
        int[] arr = { 9, 3, 7, 4, 69, 420, 42 };

        MyBubbleSort bubble = new(arr);

        bubble.Sort();

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}