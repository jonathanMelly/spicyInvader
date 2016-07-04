using System;


namespace SpicyInvader
{
    public abstract class StringDisplayable2D
    {
        protected short x;
        protected short y;

        public abstract string getSprite();
        protected abstract ConsoleColor getColor();

        protected readonly ConsoleWrapper console;

        public StringDisplayable2D(ConsoleWrapper console,int x, int y)
        {
            this.x = Convert.ToInt16(x);
            this.y = Convert.ToInt16(y);

            this.console = console;
        }

        public void erase()
        {
            console.setCursorPosition(x, y);
            console.write(new String(' ', getSprite().Length));
            resetCursor();
        }

        public void display()
        {
            console.setCursorPosition(x, y);
            console.setForegroundColor( getColor());
            console.write(getSprite());
            resetCursor();
        }

        private void resetCursor()
        {
            console.setCursorPosition(0, 0);
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
