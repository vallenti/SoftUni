using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YoloSnake.Enums;
using YoloSnake.Interfaces;
using YoloSnake.Models;

namespace YoloSnake.Core
{
    class Engine : IRunnable
    {
        private IKeyboardHandler keyboardHandler;
        private IDrawer drawer;

        public Engine(IKeyboardHandler keyboardHandler, IDrawer drawer)
        {
            this.keyboardHandler = keyboardHandler;
            this.drawer = drawer;
        }

        public void Run()
        {
            Snake player = new Snake('o', 10, 20, 3);
            Direction direction = Direction.Right;
            while(true)
            {
                if(keyboardHandler.IsKeyAvailable)
                {
                    ConsoleKey pressedKey = keyboardHandler.PressedKey;
                    switch (pressedKey)
                    {
                        case ConsoleKey.UpArrow:
                            direction = Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            direction = Direction.Down;
                            break;
                        case ConsoleKey.LeftArrow:
                            direction = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            direction = Direction.Right;
                            break;
                        default:
                            break;
                    }
                    player.ChangeDirection(direction);
                }
                player.Move();
                player.Draw(drawer);
                Thread.Sleep(500);
            }
        }
    }
}
