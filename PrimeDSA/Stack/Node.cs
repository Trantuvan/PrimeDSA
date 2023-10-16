namespace PrimeDSA.Stack;

public class Node<T>
{
    public T Value { get; set; } = default!;
    public Node<T>? Prev { get; set; }
}
