using System.ComponentModel;

namespace PrimeDSA.DoublyLinkedList;
public class MyDoubleLinkedList<T>
{
    public int Length { get; private set; }
    public Node<T>? _head;
    private Node<T>? _tail;

    public MyDoubleLinkedList()
    {
        Length = 0;
        _head = _tail = default;
    }

    public void Prepend(T item)
    {
        Length++;
        Node<T> node = new() { Value = item };

        if (_head is null)
        {
            _head = _tail = node;
            return;
        }

        node.Next = _head;
        _head.Prev = node;
        _head = node;
    }

    public void Append(T item)
    {
        Length++;
        Node<T> node = new() { Value = item };

        if (_tail is null)
        {
            _head = _tail = node;
            return;
        }

        node.Prev = _tail;
        _tail.Next = node;
        _tail = node;
    }

    public void InsertAt(int index, T item)
    {
        //* Append & Prepend are create new node
        //* InsertAt is modified value of a node
        //* so if index > Length (walk off the linked list)
        if (index > Length)
        {
            throw new IndexOutOfRangeException($"Index {index} must be in the range from 0 to {Length}");
        }

        if (index < 0)
        {
            throw new IndexOutOfRangeException($"Index must be non-negative");
        }

        //* insert at the head
        if (index is 0)
        {
            Prepend(item);
            return;
        }

        //* insert at the tail
        if (index == Length)
        {
            Append(item);
            return;
        }

        //* in the middle
        Length++;
        var curr = GetAt(index);
        Node<T> node = new() { Value = item };

        node.Next = curr;
        node.Prev = curr!.Prev;
        curr.Prev = node;

        if (node.Prev != null)
        {
            node.Prev.Next = node;
        }
    }

    public T? Remove(T item)
    {
        var curr = _head;

        for (int i = 0; i < Length; i++)
        {
            //* walk off the linked list length
            if (curr is null)
            {
                return default;
            }

            if (item!.Equals(curr.Value))
            {
                break;
            }
            curr = curr.Next;
        }

        if (curr is null)
        {
            return default;
        }

        Node<T> node = new() { Value = item };

        return RemoveNode(node);
    }

    public T? RemoveAt(int index)
    {
        var node = GetAt(index);

        if (node is null)
        {
            return default;
        }

        return RemoveNode(node);
    }

    public T? Get(int index)
    {
        var node = GetAt(index);

        return node is null ? default : node.Value;
    }

    private T? RemoveNode(Node<T> node)
    {
        Length--;

        //* remove the last item in list
        if (Length is 0)
        {
            //* head is nullable Node<T>? must be check here
            var output = _head is null ? default : _head.Value;
            _head = _tail = null;
            return output;
        }

        // disconnect link
        if (node.Prev is not null)
        {
            node.Prev.Next = node.Next;
        }

        if (node.Next is not null)
        {
            node.Next.Prev = node.Prev;
        }

        //* remove head
        if (node == _head)
        {
            _head = node.Next;
        }

        //*remve tail
        if (node == _tail)
        {
            _tail = node.Prev;
        }

        //* free memory for node
        node.Prev = node.Next = null;

        return node.Value;
    }

    private Node<T>? GetAt(int index)
    {
        var curr = _head;

        for (int i = 0; i < index; i++)
        {
            //* check for index out of range (walk off the linked list)
            if (curr is null)
            {
                return default;
            }

            //* at index 0 curr.next will have index 1
            //* so we don't walk to the last index curr will be the last curr Node
            //* must check this node outside of for loop is null
            curr = curr.Next;
        }

        if (curr is null)
        {
            return default;
        }

        return curr;
    }
}