using PrimeDSA.MazeSolver;

namespace PrimeDSA;

public class Program
{
    public static void Main()
    {
        string[] maze = {
            "xxxxxxxxxx x",
            "x        x x",
            "x        x x",
            "x xxxxxxxx x",
            "x          x",
            "x xxxxxxxxxx",
        };

        MyMazeSolver solver = new(maze, "x", new Point(10, 0), new Point(1, 5));

        List<Point> points = solver.Solve();

        for (int i = 0; i < points.Count; i++)
        {
            Console.WriteLine($"index {i}: x {points[i].X} y {points[i].Y}");
        }
    }
}