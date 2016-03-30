namespace _08.DistanceInLabyrinth
{
    using System;
    using System.Collections.Generic;

    public class Maze
    {
        private static string[,] maze;
        private static int mazeSize;
        private static Cell startCell;

        static void Main()
        {
            ReadInput(); //copy-paste from zero-test.txt in project folder
            FindAllDistances();
            MarkUnreachableCells();
            PrintMatrix();
        }

        private static void ReadInput()
        {
            mazeSize = int.Parse(Console.ReadLine());
            maze = new string[mazeSize, mazeSize];

            for (int row = 0; row < mazeSize; row++)
            {
                string[] line = Console.ReadLine().Split();
                for (int col = 0; col < mazeSize; col++)
                {
                    maze[row, col] = line[col];
                    if (line[col] == "*")
                    {
                        startCell = new Cell(row, col, 0);
                    }
                }
            }
        }

        private static void FindAllDistances()
        {
            //implementing BFS
            Queue<Cell> visitedCells = new Queue<Cell>();
            VisitCell(visitedCells, startCell.Row, startCell.Col, 0);

            while (visitedCells.Count > 0)
            {
                Cell currentCell = visitedCells.Dequeue();
                int row = currentCell.Row;
                int col = currentCell.Col;
                int distance = currentCell.Distance;

                int maxRow = Math.Min(row + 1, mazeSize - 1);
                int minRow = Math.Max(row - 1, 0);
                int maxCol = Math.Min(col + 1, mazeSize - 1);
                int minCol = Math.Max(col - 1, 0);

                VisitCell(visitedCells, maxRow, col, distance + 1);
                VisitCell(visitedCells, minRow, col, distance + 1);
                VisitCell(visitedCells, row, maxCol, distance + 1);
                VisitCell(visitedCells, row, minCol, distance + 1);
            }
        }

        private static void VisitCell(Queue<Cell> visitedCells, int row, int col, int distance)
        {
            //case for starting cell
            if(maze[row, col] == "*")
            {
                EnqueueCell(visitedCells, row, col, distance);
            }

            //case for every other available for visiting cell
            if(maze[row, col] != "x" && maze[row, col] == "0")
            {
                maze[row, col] = distance.ToString();
                EnqueueCell(visitedCells, row, col, distance);
            }
        }

        private static void EnqueueCell(Queue<Cell> visitedCells, int row, int col, int distance)
        {
            Cell cell = new Cell(row, col, distance);
            visitedCells.Enqueue(cell);
        }

        private static void MarkUnreachableCells()
        {
            for (int row = 0; row < mazeSize; row++)
            {
                for (int col = 0; col < mazeSize; col++)
                {
                    if (maze[row, col] == "0")
                    {
                        maze[row, col] = "u";
                    }
                }
            }
        }

        private static void PrintMatrix()
        {
            Console.WriteLine();
            for (int row = 0; row < mazeSize; row++)
            {
                for (int col = 0; col < mazeSize; col++)
                {
                    Console.Write(maze[row, col] + " ");
                }
                Console.WriteLine();
            }
        }   
    } 
}
