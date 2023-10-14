namespace PrimeDSA.Queue;

public class MyQueue<T>
{
    public int Length { get; private set; }
    private Node<T>? _head;
    private Node<T>? _tail;

    public MyQueue()
    {
        Length = 0;
        _head = null;
        _tail = null;
    }

    public void Enqueue(T item)
    {
        Length++;
        var node = new Node<T> { Value = item };

        if (_tail is null)
        {
            _head = node;
            _tail = node;
            return;
        }

        _tail.Next = node;
        _tail = node;
    }

    public T? Deque()
    {
        if (_head is null)
        {
            return default;
        }

        Length--;
        var head = _head;
        _head = head.Next;

        //* freeze memory for var head
        head.Next = null;

        //* if pop the last elem in queue
        if (Length.Equals(0))
        {
            _tail = null;
        }

        return head.Value;
    }

    public T? Peek()
    {
        if (_head is null)
        {
            return default;
        }

        return _head.Value;
    }
}
