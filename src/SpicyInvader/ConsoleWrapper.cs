using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    public interface ConsoleWrapper
    {
        void setCursorPosition(short x, short y);
        void write(string text);
        void setForegroundColor(ConsoleColor color);
        void setWindowSize(int width, int height);
        void setCursorVisible(bool visible);

        int getWindowWidth();
        int getWindowHeight();
    }
}
