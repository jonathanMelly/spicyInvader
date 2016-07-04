//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

using System;

namespace SpicyInvader
{
    public abstract class Missile
    {
        protected short xPosition;
        protected short yPosition;

        public Missile(short xPosition,short yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }

        public abstract string getSprite();
        public abstract ConsoleColor getColor();
        protected abstract bool computeNewPosition();

        public bool goForward()
        {
            erase();
            bool notDestroyed = computeNewPosition();

            if(notDestroyed)
            {
                display();
            }
            

            return notDestroyed;
        }

        public void erase()
        {
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write(new String(' ',getSprite().Length));
        }

        public void display()
        {
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write(getSprite());
        }

        
    }
}
