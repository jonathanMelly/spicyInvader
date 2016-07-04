

using System;
using SpicyInvader;

namespace SpicyInvaderTests
{
    public class TestConsole : ConsoleWrapper
    {
        private int width;
        private int height;

        public TestConsole(int width, int height)
        {
            this.height = height;
            this.width = width;
        }

        public int getWindowHeight()
        {
            return height;
        }

        public int getWindowWidth()
        {
            return width;
        }

        public void setCursorPosition(short x, short y)
        {
            Console.WriteLine("SetCursor :" + x + "," + y);
        }

        public void setCursorVisible(bool visible)
        {
            Console.WriteLine("SetCursorVisible:" + visible);
        }

        public void setForegroundColor(ConsoleColor color)
        {
            Console.WriteLine("Color:" + color);
        }

        public void setWindowSize(int width, int height)
        {
            Console.WriteLine("WindowSize:" + width + "," + height);
        }

        public void write(string text)
        {
            Console.WriteLine("Write:"+text);
        }
    }
}
