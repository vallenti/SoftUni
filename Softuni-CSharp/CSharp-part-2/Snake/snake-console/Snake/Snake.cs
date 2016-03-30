using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    struct Position
    {
        public Position(int row, int col){
            this.row = row;
            this.col = col;
        }
        public int row;
        public int col;
    }
    class Snake
    {
        //array for directions of snake
        static Position[] directions = new Position[]
            {
                new Position(0, 1),  //move right
                new Position(0, -1),  //move left
                new Position(1, 0),  //move down
                new Position(-1, 0)   //move up
            };
        //indexes for the array
        static byte right = 0;
        static byte left = 1;
        static byte down = 2;
        static byte up = 3;

        static char[] snakeHeadSymbol = new char[]
        {
            '>',  //right
            '<',  //left
            'v',  //down
            '^'   //up
        };

        static int direction = right; // current direction that snake is moving

        static int lastFoodTime = 0;
        static int foodDissapearTime = 8000; //8000 miliseconds = 8 seconds
        static int penalty = 0;
        static Queue<Position> snakeElements = new Queue<Position>();
        static Random randGen = new Random();
        static Position food;

        static void RemoveScrollbars()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.BufferWidth;
        }
        static void GenerateFirstSnakeElements()
        {
            for (int i = 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(10, i));
            }
        }
        static void PrintSnake(Queue<Position> snakeElements)
        {
            foreach (Position position in snakeElements)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.Write("*");
            }
        }
        static Position GenerateFood(ref int lastFoodTime, Random randGen)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                food = new Position(randGen.Next(0, Console.WindowHeight),
                 randGen.Next(0, Console.WindowWidth));
            } while (snakeElements.Contains(food));
            lastFoodTime = Environment.TickCount;
            Console.SetCursorPosition(food.col, food.row);
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.White;
            return food;
        }

        static void Main()
        {
            RemoveScrollbars();
            food = GenerateFood(ref lastFoodTime, randGen);
            GenerateFirstSnakeElements();
            PrintSnake(snakeElements);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();
                    if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (direction != left) direction = right;
                    }
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (direction != right) direction = left;
                    }
                    if (pressedKey.Key == ConsoleKey.DownArrow)
                    {
                        if (direction != up) direction = down;
                    }
                    if (pressedKey.Key == ConsoleKey.UpArrow)
                    {
                        if (direction != down) direction = up;
                    }
                }

                Position snakeHead = snakeElements.Last();
                Position nextDirection = directions[direction];
                Position snakeNewHead = new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);

                //check if snake went out of console and move snake to the other side of console
                if (snakeNewHead.col < 0) snakeNewHead.col = Console.WindowWidth - 1;
                if (snakeNewHead.col >= Console.WindowWidth) snakeNewHead.col = 0;
                if (snakeNewHead.row < 0) snakeNewHead.row = Console.WindowHeight - 1;
                if (snakeNewHead.row >= Console.WindowHeight) snakeNewHead.row = 0;

                //if  snake hit its tail -> game over
                if (snakeElements.Contains(snakeNewHead))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.WindowHeight / 2);
                    Console.WriteLine("Game over");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.WindowHeight / 2 + 1);
                    int userPoints = (snakeElements.Count() - 6) * 100 - penalty;
                    userPoints = Math.Max(userPoints, 0);
                    Console.WriteLine("Your points are {0}", userPoints);
                    Console.ReadKey();
                    return;
                }

                //
                Console.SetCursorPosition(snakeHead.col, snakeHead.row);
                Console.Write("*");
                snakeElements.Enqueue(snakeNewHead);
                Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(snakeHeadSymbol[direction]);
                Console.ForegroundColor = ConsoleColor.White;

                if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                {
                    //feeding the snake
                    food = GenerateFood(ref lastFoodTime, randGen);
                }
                else
                {
                    //snake is just moving
                    Position last = snakeElements.Dequeue(); //remove snake tail if she didnt eat a food
                    Console.SetCursorPosition(last.col, last.row);
                    Console.Write(" ");
                }

                //check if food has disappeared
                if ((Environment.TickCount - lastFoodTime) >= foodDissapearTime)
                {
                    //peanlty for missed food
                    penalty += 50;

                    //remove old food
                    Console.SetCursorPosition(food.col, food.row);
                    Console.WriteLine(" ");

                    //create new food
                    food = GenerateFood(ref lastFoodTime, randGen);
                }

                Thread.Sleep(100);
            }
        } 
    }
}
