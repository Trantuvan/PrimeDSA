using PrimeDSA.TwoCrystalBall;

namespace PrimeDSA.UnitTest;

public class MyTwoCrystalBallTest
{
    private bool[] _data;
    private int _idx;

    [SetUp]
    public void SetUp()
    {
        var rnd = new Random();
        _idx = (int)Math.Floor(rnd.NextDouble() * 10_000);
        _data = new bool[10_000];

        Array.Fill(_data, false);

        for (int i = _idx; i < _data.Length; i++)
        {
            _data[i] = true;
        }

    }

    [Test]
    public void ShouldReturnIdx()
    {
        //* Arrange
        MyTwoCrystalBall crystalBall = new(_data);

        //* Act
        var actual = crystalBall.Search();
        var expected = _idx;
        
        //* Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ShouldReturnMinusOne()
    {
        //* Arrange
        _data = new bool[821];
        Array.Fill(_data, false);
        MyTwoCrystalBall crystalBall = new(_data);

        //* Act
        var actual = crystalBall.Search();

        //* Assert
        Assert.That(actual, Is.EqualTo(-1));
    }
}
