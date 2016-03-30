using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class PingPong
{
    static int numberOfPlayers = 0;
    static int difficultyLevel = 100;
    static int firstPlayerpadSize = 6;
    static int secondPlayerpadSize = 9;
    static int ballPosX = 0;
    static int ballPosY = 0;
    static bool ballDirectionUp = true;
    static bool ballDirectionRight = true;
    static int firstPlayerPos = 0;
    static int secondPlayerPos = 0;
    static int firstPlayerPoints = 0;
    static int secondPlayerPoints = 0;
    static Random randGen = new Random();

    static void SetInitialPositions()
    {
        //remove scrollbars
        Console.ForegroundColor = ConsoleColor.White;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;

        //set pads in center
        firstPlayerPos = Console.WindowHeight / 2-firstPlayerpadSize/2;
        secondPlayerPos = Console.WindowHeight / 2-secondPlayerpadSize/2;

        SetBallAtCenter();
    }
    static void PrintMenu()
    {
        Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 - 3);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1 - Easy");
        Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 - 2);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("2 - Normal");
        Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 - 1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("3 - Hard");
        Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Choose level of difficulty: ");
        int level = int.Parse(Console.ReadLine());
        switch (level)
        {
            case 1:
                firstPlayerpadSize = 9;
                secondPlayerpadSize = 6;
                difficultyLevel = 50;
                break;
            case 2:
                firstPlayerpadSize = 7;
                secondPlayerpadSize = 7;
                difficultyLevel = 60;
                break;
            case 3:
                firstPlayerpadSize = 6;
                secondPlayerpadSize = 9;
                difficultyLevel = 70;
                break;
            default:
                firstPlayerpadSize = 7;
                secondPlayerpadSize = 7;
                difficultyLevel = 60;
                break;
        }
    }
    static void SetBallAtCenter()
    {
        ballPosX = Console.WindowWidth / 2;
        ballPosY = Console.WindowHeight / 2;
    }
    static void DrawFirstPlayer()
    {
        for (int y = firstPlayerPos; y < firstPlayerPos +  firstPlayerpadSize; y++)
        {
            PrintAtPosition(0, y, 'H',ConsoleColor.White);
        }
    }    
    static void DrawSecondPlayer()
    {
        for (int y = secondPlayerPos; y < secondPlayerPos + secondPlayerpadSize; y++)
        {
            PrintAtPosition(Console.WindowWidth - 1, y, 'H', ConsoleColor.White);
        }
    }
    static void DrawBall()
    {
        PrintAtPosition(ballPosX, ballPosY, '@', ConsoleColor.Yellow);
    }
    static void PrintResult()
    {
        Console.SetCursorPosition(Console.WindowWidth / 2-2,0);
        Console.Write("{0} - {1}", firstPlayerPoints, secondPlayerPoints);
    }
    static void PrintCentralLine()
    {
        for (int i = 1; i <= Console.WindowHeight - 1; i++)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, i);
            Console.Write("|");
        }
    }
    static void PrintAtPosition(int x, int y, char symbol, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(symbol);
    }

    static void MoveFirstPlayerUp()
    {
        if (firstPlayerPos > 0)
        {
            firstPlayerPos--;
        }
    }
    static void MoveFirstPlayerDown()
    {
        if (firstPlayerPos+firstPlayerpadSize < Console.WindowHeight)
        {
            firstPlayerPos++;
        }
    }
    static void MoveSecondPlayerUp()
    {
        if (secondPlayerPos > 0)
        {
            secondPlayerPos--;
        }
    }
    static void MoveSecondPlayerDown()
    {
        if (secondPlayerPos + secondPlayerpadSize < Console.WindowHeight)
        {
            secondPlayerPos++;
        }
    }
    static void MoveBall()
    {
        if (ballDirectionUp)
        {
            ballPosY--;
        }
        else
        {
            ballPosY++;
        }
        if (ballDirectionRight)
        {
            ballPosX++;
        }
        else
        {
            ballPosX--;
        }
        if (ballPosY == 0)
        {
            ballDirectionUp = false;
        }
        if (ballPosY == Console.WindowHeight-1)
        {
            ballDirectionUp = true;
        }
        //case if 1st player win
        if (ballPosX == Console.WindowWidth-1)
        {
            ballDirectionRight = false;
            firstPlayerPoints++;
            SetBallAtCenter();
            if (numberOfPlayers == 1)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You've won");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 14, Console.WindowHeight / 2 + 2);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("First player won");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 14, Console.WindowHeight / 2 + 2);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        //case if 2nd player win
        if (ballPosX == 0)
        {
            ballDirectionRight = true;
            secondPlayerPoints++;
            SetBallAtCenter();
            if (numberOfPlayers == 1)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You've lost");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 14, Console.WindowHeight / 2 + 2);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Second player won");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 14, Console.WindowHeight / 2 + 2);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        if (ballPosX < 2)
        {
            if (ballPosY >= firstPlayerPos && ballPosY <= firstPlayerPos + firstPlayerpadSize)
            {
                ballDirectionRight = true;
            }
        }
        if (ballPosX >= Console.WindowWidth - 2)
        {
            if (ballPosY >= secondPlayerPos && ballPosY <= secondPlayerPos + secondPlayerpadSize)
            {
                ballDirectionRight = false;
            }
        }
    }
    static void MoveSecondPlayerAI()
    {
        int randNumber = randGen.Next(1, 101);
        if(randNumber <= difficultyLevel)
        {
            if (ballDirectionUp)
            {
                MoveSecondPlayerUp();
            }
            else
            {
                MoveSecondPlayerDown();
            }
        }
        
    }

    static void SinglePlayer()
    {
        PrintMenu();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    MoveFirstPlayerUp();
                }
                if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    MoveFirstPlayerDown();
                }
            }
            MoveSecondPlayerAI();
            MoveBall();
            Console.Clear();
            DrawFirstPlayer();
            DrawSecondPlayer();
            DrawBall();
            PrintResult();
            PrintCentralLine();
            if (firstPlayerPoints == 11 || secondPlayerPoints==11) return;
            Thread.Sleep(60);
        }
    }
    static void MultiPlayer()
    {
        firstPlayerpadSize = 7;
        secondPlayerpadSize = 7;
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.W)
                {
                    MoveFirstPlayerUp();
                }
                if (pressedKey.Key == ConsoleKey.S)
                {
                    MoveFirstPlayerDown();
                }
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    MoveSecondPlayerUp();
                }
                if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    MoveSecondPlayerDown();
                }
            }
            MoveBall();
            Console.Clear();
            DrawFirstPlayer();
            DrawSecondPlayer();
            DrawBall();
            PrintResult();
            PrintCentralLine();
            Thread.Sleep(60);
        }
    }

    static void Main()
    {
        while (true)
        {
            SetInitialPositions();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 - 5);
            Console.Write("Number of players (1 or 2): ");
            try
            {
                numberOfPlayers = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2);
                Console.WriteLine("Please enter valid number.");
            }
            catch (OverflowException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2);
                Console.WriteLine("Too big number");
            }
        }
        if (numberOfPlayers == 1)
        {
            SinglePlayer();
        }
        else
        {
            MultiPlayer();
        }
    }
}

