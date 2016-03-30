using Escape_from_Labyrinth;
using System;
using System.Collections.Generic;
using System.Text;

public class EscapeFromLabyrinth
{
    const char VisitedCell = 's';
    static int cols;
    static int rows;
    static char[,] labyrinth;

    public static void Main()
    {
        cols = int.Parse(Console.ReadLine());
        rows = int.Parse(Console.ReadLine());
        labyrinth = new char[rows, cols];
        
        for (int row = 0; row < rows; row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < cols; col++)
            {
                labyrinth[row, col] = line[col];
            }
        }

        var shortestPathToExit = FindShortestPath();
        if(shortestPathToExit == null)
        {
            Console.WriteLine("No exit!");
        }
        else if(shortestPathToExit == "")
        {
            Console.WriteLine("Start is at the exit.");
        }
        else
        {
            Console.WriteLine("Shortest exit: "+shortestPathToExit);
        }

    }

    private static Point FindStartPosition()
    {
        for (int row = 0; row < rows; row++)
        {
            
            for (int col = 0; col < cols; col++)
            {
                if(labyrinth[row,col] == VisitedCell)
                {
                    return new Point() { X = row, Y = col };
                }
            }
        }

        return null;
    }

    private static string FindShortestPath()
    {
        var queue = new Queue<Point>();
        Point startPosition = FindStartPosition();
        if(startPosition == null)
        {
            return null;
        }

        queue.Enqueue(startPosition);
        while(queue.Count > 0)
        {
            var currentCell = queue.Dequeue();
            if(IsExit(currentCell))
            {
                return TraceBackPath(currentCell);
            }

            TryDirection(queue, currentCell, "U", -1, 0);
            TryDirection(queue, currentCell, "R", 0, 1);
            TryDirection(queue, currentCell, "D", 1, 0);
            TryDirection(queue, currentCell, "L", 0, -1);
        }

        return null;
    }

    private static void TryDirection(Queue<Point> queue, Point currentCell, string direction, int deltaX, int deltaY)
    {
        int newX = currentCell.X + deltaX;
        int newY = currentCell.Y + deltaY;
        if(newX >= 0 && newX < rows && newY >= 0 && newY < cols && labyrinth[newX, newY] == '-')
        {
            labyrinth[newX, newY] = VisitedCell;
            var nextCell = new Point()
            {
                X = newX,
                Y = newY,
                Direction = direction,
                PreviousPoint = currentCell
            };
            queue.Enqueue(nextCell);
        }
    }

    private static string TraceBackPath(Point currentCell)
    {
        var path = new StringBuilder();
        while(currentCell.PreviousPoint != null)
        {
            path.Append(currentCell.Direction);
            currentCell = currentCell.PreviousPoint;
        }

        var pathReversed = new StringBuilder();
        for (int i = path.Length - 1; i >= 0; i--)
        {
            pathReversed.Append(path[i]);
        }

        return pathReversed.ToString();
    }

    private static bool IsExit(Point currentCell)
    {
        bool isOnBorderX = currentCell.X == 0 || currentCell.X == rows - 1;
        bool isOnBorderY = currentCell.Y == 0 || currentCell.Y == cols - 1;
        return isOnBorderX || isOnBorderY;
    }
}
