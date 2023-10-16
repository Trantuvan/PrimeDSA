using PrimeDSA.Stack;

namespace PrimeDSA.UnitTest;

public class MyStackTest
{
    private MyStack<int> list;

    [SetUp]
    public void Setup()
    {
        list = new MyStack<int>();
    }

    [Test]
    public void ShouldPush3Item()
    {
        //* Arrange
        list.Push(5);
        list.Push(7);
        list.Push(9);

        //* Act
        var actual = list.Length;
        var expected = 3;

        //* Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldPop()
    {
        //* Arrange
        list.Push(5);
        list.Push(7);
        list.Push(9);

        //* Act
        var actual = list.Pop();
        var expected = 9;
        var listLength = 2;

        //* Assert
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(list.Length, Is.EqualTo(listLength));
    }

    [Test]
    public void ShouldPopToZeroLength()
    {
        //* Arrange
        list.Push(5);
        list.Push(7);
        list.Push(9);

        //* Act
        var actual1 = list.Pop();
        var expected1 = 9;

        list.Push(11);

        var actual2 = list.Pop();
        var expected2 = 11;

        var actual3 = list.Pop();
        var expected3 = 7;

        var actual4 = list.Pop();
        var expected4 = 5;

        var actual5 = list.Pop();
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

    [Test]
    public void ShouldPeek()
    {
        //* Arrange
        list.Push(5);
        list.Push(7);
        list.Push(9);

        //* Act
        var actual = list.Peek();
        var expected = 9;

        //* Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
