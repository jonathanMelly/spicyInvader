using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    class MsDosConsole : ConsoleWrapper
    {
        public int getWindowHeight()
        {
            return Console.WindowHeight;
        }

        public int getWindowWidth()
        {
            return Console.WindowWidth;
        }

        public void setCursorPosition(short x, short y)
        {
            Console.SetCursorPosition(x, y);
        }

        public void setCursorVisible(bool visible)
        {
            Console.CursorVisible = visible;
        }

        public void setForegroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void setWindowSize(int width, int height)
        {
            Console.SetWindowSize(width, height);
        }

        public void write(string text)
        {
            Console.Write(text);
        }
    }
}
