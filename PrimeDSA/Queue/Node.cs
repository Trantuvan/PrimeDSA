namespace PrimeDSA.Queue;

public class Node<T>
{
    public T Value { get; set; } = default!;
    public Node<T>? Next { get; set; }
};
