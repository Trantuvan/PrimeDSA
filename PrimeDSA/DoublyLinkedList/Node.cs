namespace PrimeDSA.DoublyLinkedList;

public class Node<T>
{
    public T Value { get; set; } = default!;
    public Node<T>? Next { get; set; }
    public Node<T>? Prev { get; set; }
}