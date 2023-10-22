using PrimeDSA.MazeSolver;

namespace PrimeDSA.UnitTest;

public class MyMazeSolverTest
{
    private string[] _maze;

    [SetUp]
    public void Setup()
    {
        _maze = new string[] {
            "xxxxxxxxxx x",
            "x        x x",
            "x        x x",
            "x xxxxxxxx x",
            "x          x",
            "x xxxxxxxxxx",
        };
    }

    [Test]
    public void ShouldFindPath()
    {
        // Arrange
        var mazeResult = new List<Point>{
            new(10, 0),
            new(10, 1),
            new(10, 2),
            new(10, 3),
            new(10, 4),
            new(9, 4),
            new(8, 4),
            new(7, 4),
            new(6, 4),
            new(5, 4),
            new(4, 4),
            new(3, 4),
            new(2, 4),
            new(1, 4),
            new(1, 5)
        };

        // Act
        var solver = new MyMazeSolver(_maze, "x", new Point(10, 0), new Point(1, 5));
        var result = solver.Solve();

        var actual = DrawPath(_maze, result);
        var expected = DrawPath(_maze, mazeResult);

        // Assert
        Assert.That(actual, Is.EquivalentTo(expected));
    }

    private string[] DrawPath(string[] data, List<Point> path)
    {
        var data2 = data.Select(row => row.ToCharArray()).ToArray();

        path.ForEach(p =>
        {
            //* check Point must be in the string[][] array
            if (p.Y < data2.Length && p.X < data2[p.Y].Length)
            {
                data2[p.Y][p.X] = '*';
            }
        });

        return data2.Select(d => string.Join("", d)).ToArray();
    }
}
