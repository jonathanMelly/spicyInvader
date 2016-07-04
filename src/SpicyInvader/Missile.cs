//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

using System;

namespace SpicyInvader
{
    public abstract class Missile:StringDisplayable2D
    {

        public Missile(int x, int y) : base(x, y)
        {
            //Parent
        }

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
        
    }
}
