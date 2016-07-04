using System;


namespace SpicyInvader
{
    public abstract class StringDisplayable2D
    {
        protected short x;
        protected short y;

        public abstract string getSprite();
        protected abstract ConsoleColor getColor();

        public StringDisplayable2D(int x, int y)
        {
            this.x = Convert.ToInt16(x);
            this.y = Convert.ToInt16(y);
        }

        public void erase()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(new String(' ', getSprite().Length));
        }
        public void display()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = getColor();
            Console.Write(getSprite());
        }

        public short getX()
        {
            return x;
        }

        public short getY()
        {
            return y;
        }
    }
}
