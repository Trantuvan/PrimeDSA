using PrimeDSA.Stack;

namespace PrimeDSA;

public class Program
{
    public static void Main()
    {
        MyStack<int> list = new();
        list.Push(1);
        list.Push(2);
        list.Push(3);

        Console.WriteLine($"list length: {list.Length}");
        Console.WriteLine(list.Pop());

        Console.WriteLine($"list length: {list.Length}");
        list.Push(11);
        Console.WriteLine(list.Pop());
        Console.WriteLine(list.Pop());
        Console.WriteLine(list.Pop());
        Console.WriteLine(list.Pop());
        Console.WriteLine($"list length: {list.Length}");
    }
}