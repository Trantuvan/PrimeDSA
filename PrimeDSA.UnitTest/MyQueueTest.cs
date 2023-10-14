using PrimeDSA.Queue;

namespace PrimeDSA.UnitTest;

public class MyQueueTest
{
    private MyQueue<int> list;

    [SetUp]
    public void Setup()
    {
        list = new MyQueue<int>();
    }

    [Test]
    public void ShouldEnqueu3Item()
    {
        //* Arrange
        list.Enqueue(5);
        list.Enqueue(7);
        list.Enqueue(9);

        //* Act
        var actual = list.Length;
        var expected = 3;

        //* Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldDeque()
    {
        //* Arrange
        list.Enqueue(5);
        list.Enqueue(7);
        list.Enqueue(9);

        //* Act
        var actual = list.Deque();
        var expected = 5;
        var listLength = list.Length;

        //* Assert
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(listLength, Is.EqualTo(list.Length));
    }

    [Test]
    public void ShouldDequeToZeroLength()
    {
        //* Arrange
        list.Enqueue(5);
        list.Enqueue(7);
        list.Enqueue(9);

        //* Act
        var actual1 = list.Deque();
        var expected1 = 5;

        list.Enqueue(11);

        var actual2 = list.Deque();
        var expected2 = 7;

        var actual3 = list.Deque();
        var expected3 = 9;

        var actual4 = list.Deque();
        var expected4 = 11;

        var actual5 = list.Deque();
        var expected5 = 0;

        var actualLength = list.Length;
        var expectedLength = 0;

        //* Assert
        Assert.That(actual1, Is.EqualTo(expected1));
        Assert.That(actual2, Is.EqualTo(expected2));
        Assert.That(actual3, Is.EqualTo(expected3));
        Assert.That(actual4, Is.EqualTo(expected4));
        Assert.That(actual5, Is.EqualTo(expected5));
        Assert.That(actualLength, Is.EqualTo(expectedLength));
    }
}