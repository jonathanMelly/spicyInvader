//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

using System;

namespace SpicyInvader
{
    public abstract class Missile : StringDisplayable2D
    {

        public Missile(ConsoleWrapper console, int x, int y) : base(console, x, y)
        {
            //Parent
        }

        protected abstract bool goToNextPosition(Enemy[] enemies);

        public bool goForward(Enemy[] enemies)
        {
            erase();
            bool missileHasMoved = goToNextPosition(enemies);

            if (missileHasMoved)
            {
                display();
            }


            return missileHasMoved;
        }

    }
}
