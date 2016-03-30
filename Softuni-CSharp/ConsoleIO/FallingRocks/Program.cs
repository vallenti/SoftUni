using System;
using System.Collections.Generic;
using System.Threading;

class FallingRocks
{
    static int dwarfPosition = 0;
    static string dwarf = "(0)";
    static List<Rock> rocks = new List<Rock>();
    static char[] typeRocks = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
    static ConsoleColor[] colors = new ConsoleColor[] {ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow };
    static Random randGen = new Random();
    static byte livesCount = 5;
    static uint score = 0;
    static int playfieldWidth = 30;
    struct Rock
    {
        public int x;
        public int y;
        public string ch;
        public ConsoleColor color;
    }
    
    static void Main()
    {
        SetInitialPositions();
        while (true)
        {
            {
                Rock newRock = new Rock();
                newRock.x = randGen.Next(0, playfieldWidth);
                newRock.y = 0;
                int typeRock = randGen.Next(0, typeRocks.Length);
                newRock.ch = typeRocks[typeRock].ToString();
                int rockColor = randGen.Next(0, colors.Length);
                newRock.color = colors[rockColor];
                rocks.Add(newRock);
            }
            bool isAlive = true;
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    MoveDwarfLeft();
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    MoveDwarfRight();
                }
            }

            List<Rock> newList = new List<Rock>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock newRock = new Rock();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.ch = oldRock.ch;
                newRock.color = oldRock.color;
                if ((newRock.x == dwarfPosition || newRock.x == dwarfPosition + 1 || newRock.x == dwarfPosition + 2) && newRock.y == Console.WindowHeight - 1)
                {
                    isAlive = false;
                    livesCount--;
                    if (livesCount <= 0)
                    {
                        Console.Clear();
                        PrintAtPosition(20, 10, "Game over!!!", ConsoleColor.Red);
                        PrintAtPosition(16, 12, "Your score is " + score, ConsoleColor.White);
                        PrintAtPosition(15, 14, "Press [enter] to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
                if (newRock.y == Console.WindowHeight)
                {
                    score++;
                }
            }
            rocks = newList;
            
            Console.Clear();
            if (isAlive)
            {
                PrintAtPosition(dwarfPosition, Console.WindowHeight - 1, dwarf);
            }
            else
            {
                rocks.Clear();
                PrintAtPosition(dwarfPosition, Console.WindowHeight - 1, " X ",ConsoleColor.Red);
            }
            foreach (Rock rock in rocks)
            {
                PrintAtPosition(rock.x, rock.y, rock.ch, rock.color);
            }
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                PrintAtPosition(playfieldWidth, i, "|");
            }
            PrintAtPosition(35, 5, "Lives: " + livesCount, ConsoleColor.White);
            PrintAtPosition(35, 7, "Score: " + score, ConsoleColor.White);
            Thread.Sleep(150);
        }
    }

    private static void SetInitialPositions()
    {
        Console.SetWindowSize(playfieldWidth+20, Console.WindowHeight);
        RemoveScrollBars();
        dwarfPosition = Console.WindowWidth / 2;
    }

    private static void RemoveScrollBars()
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    private static void PrintAtPosition(int x, int y, string symbol, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(symbol);
    }

    private static void MoveDwarfRight()
    {
        if (dwarfPosition <= playfieldWidth-4)
        {
            dwarfPosition++;
        }
    }

    private static void MoveDwarfLeft()
    {
        if(dwarfPosition > 0)
        {
            dwarfPosition--;
        }
    }

    

    

    
    
}

