namespace PrimeDSA.Stack;

public class MyStack<T>
{
    public int Length { get; private set; }
    private Node<T>? _head;

    public MyStack()
    {
        Length = 0;
        _head = null;
    }

    public void Push(T item)
    {
        Length++;
        var node = new Node<T> { Value = item };

        if (_head is null)
        {
            _head = node;
            return;
        }

        node.Prev = _head;
        _head = node;
    }

    public T? Pop()
    {
        Length = Math.Max(Length - 1, 0);
        var head = _head;

        if (Length == 0)
        {
            _head = null;
            return head is null ? default : head.Value;
        }

        _head = head?.Prev;

        //* free memory
        head!.Prev = null;

        return head.Value;
    }

    public T? Peek()
    {
        return _head is null ? default : _head.Value;
    }
}