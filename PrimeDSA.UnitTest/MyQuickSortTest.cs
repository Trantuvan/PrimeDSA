using PrimeDSA.QuickSort;

namespace PrimeDSA.UnitTest;

public class MyQuickSortTest
{
    int[] _nums;

    [SetUp]
    public void Setup()
    {
        _nums = new int[] { 9, 3, 7, 4, 69, 420, 42 };
    }

    [Test]
    public void ShouldSorted()
    {
        // Arrange
        MyQuickSort quickSort = new(_nums);
        int[] expected = new int[] { 3, 4, 7, 9, 42, 69, 420 };

        // Act
        int[] actual = quickSort.Sort();

        // Assert
        Assert.That(expected, Is.EquivalentTo(actual));
    }
}
