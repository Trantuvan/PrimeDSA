namespace PrimeDSA.MazeSolver;

public class MyMazeSolver
{
    private readonly int[][] DIRS = new int[4][]
    {
        new int[2] { -1, 0 },
        new int[2] { 1, 0 },
        new int[2] { 0, -1 },
        new int[2] { 0, 1 }
    };

    private readonly string[] _maze;
    private readonly string _wall;
    private readonly Point _start;
    private readonly Point _end;
    private readonly bool[][] _seen;
    //* array list to dynamically remove elem
    private readonly List<Point> _path;

    public MyMazeSolver(string[] maze, string wall, Point start, Point end)
    {
        _maze = maze;
        _wall = wall;
        _start = start;
        _end = end;
        _path = Array.Empty<Point>().ToList();
        //* create 2D bool with row length = maze.length
        _seen = new bool[maze.Length][];

        // * iterate through _seen row create 
        // * new bool[] with length = 1st string in maze
        for (int i = 0; i < _maze.Length; i++)
        {
            _seen[i] = new bool[_maze[0].Length];
            Array.Fill(_seen[i], false);
        }
    }

    private bool Walk(string[] maze, string wall, Point curr, Point end, bool[][] seen, List<Point> path)
    {
        //* Base Case
        //* 1 Off the map
        if (curr.X < 0
            || curr.X >= maze[0].Length
            || curr.Y < 0
            || curr.Y >= maze.Length)
        {
            return false;
        }

        //* 2 It's the wall
        if (maze[curr.Y][curr.X].ToString() == wall)
        {
            return false;
        }

        //* 3 It's the end
        if (curr.Y == end.Y && curr.X == end.X)
        {
            path.Add(curr);
            return true;
        }

        //* 4 We have seen it
        if (seen[curr.Y][curr.X])
        {
            return false;
        }

        //* Pre Recurse
        seen[curr.Y][curr.X] = true;
        path.Add(curr);

        //* Recurse
        foreach (var dir in DIRS)
        {
            int x = dir[0];
            int y = dir[1];

            var isWalk = Walk(maze,
                              wall,
                              new Point(curr.X + x, curr.Y + y),
                              end,
                              seen,
                              path);
            if (isWalk)
            {
                return true;
            }
        }

        //* Post Recurse
        path.RemoveAt(path.Count - 1);

        return false;
    }

    public List<Point> Solve()
    {
        Walk(_maze, _wall, _start, _end, _seen, _path);
        return _path;
    }
}
