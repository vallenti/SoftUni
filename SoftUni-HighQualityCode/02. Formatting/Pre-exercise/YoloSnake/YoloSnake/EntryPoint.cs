using YoloSnake.Core;
using YoloSnake.Interfaces;

namespace YoloSnake
{
    class EntryPoint
    {
        public static void Main()
        {
            IKeyboardHandler keyboardHandler = new KeyboardHandler();
            IDrawer consoleDrawer = new ConsoleDrawer();
            Engine engine = new Engine(keyboardHandler, consoleDrawer);
            engine.Run();
        }
    }
}
