using PrimeDSA.DoublyLinkedList;

namespace PrimeDSA;

public class Program
{
    public static void Main()
    {
        MyDoubleLinkedList<int> list = new();
        list.Append(5);
        list.Append(9);
        list.Append(7);
        list.InsertAt(10, 5);
        Console.WriteLine($"remove {list.RemoveAt(0)}");
        for (var i = 0; i < list.Length; i++)
        {
            Console.WriteLine($"index: {i} value: {list.Get(i)}");
        }
    }
}