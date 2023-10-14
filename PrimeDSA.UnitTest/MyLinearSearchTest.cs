using PrimeDSA.LinearSearch;

namespace PrimeDSA.UnitTest;

public class MyLinearSearchTest
{
    private int[] array;

    [SetUp]
    public void Setup()
    {
        array = new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 };

    }

    [Test]
    public void ShouldReturnTrueWhenFind69()
    {
        //* Arrange
        var needle = 69;
        MyLinearSearch linear = new(array, needle);

        //* Act
        var actual = linear.Search();
        
        //* Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void ShouldReturnFalseWhenFind1336()
    {
        //* Arrange
        var needle = 1336;
        MyLinearSearch linear = new(array, needle);

        //* Act
        var actual = linear.Search();

        //* Assert
        Assert.IsFalse(actual);
    }
}
