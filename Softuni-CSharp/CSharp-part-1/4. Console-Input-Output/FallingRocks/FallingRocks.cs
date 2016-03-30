using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class FallingRocks
{
    public static int dwarfX = Console.WindowWidth / 2;
    public static int dwarfY = Console.WindowHeight - 1;
    public static string dwarfShape = "(o)";
    private static void SetConsoleSettings()
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }
    static void MoveDwarfLeft()
    {
        if (dwarfX > 0)
        {
            dwarfX--;
        }
    }
    static void MoveDwarfRight()
    {
        if (dwarfX < Console.WindowWidth - 4)
        {
            dwarfX++;
        }

    }
    static void PrintAtPosition(int x, int y, char c)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(c);
    }
    static void PrintStringAtPosition(int x, int y, string c)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(c);
    }

    static void Main()
    {
        SetConsoleSettings();
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (Console.KeyAvailable)
            {
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    MoveDwarfLeft();
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    MoveDwarfRight();
                }
            }
            //move rocks
            Console.Clear();
            //draw dwarf
            PrintStringAtPosition(dwarfX, dwarfY, dwarfShape);
            //draw rocks
            Thread.Sleep(150);
        }
    }

    

}
