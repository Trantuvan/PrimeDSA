using PrimeDSA.BubbleSort;

namespace PrimeDSA.UnitTest;

public class MyBubbleSortTest
{
    private int[] _arr;

    [SetUp]
    public void SetUp()
    {
        _arr = new int[] { 9, 3, 7, 4, 69, 420, 42 };
    }

    [Test]
    public void ShouldBeSorted()
    {
        //*Arrange
        MyBubbleSort bubble = new(_arr);

        //*Act
        bubble.Sort();
        int[] expected = { 3, 4, 7, 9, 42, 69, 420 };

        //*Assert
        Assert.That(_arr, Is.EquivalentTo(expected));
    }
}
