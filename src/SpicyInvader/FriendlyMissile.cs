//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

using System;

namespace SpicyInvader
{
    public class FriendlyMissile : Missile
    {
        private const string SPRITE = "|";

        private readonly Ship ship;

        public FriendlyMissile(Ship ship, short x, short y) : base(x, y)
        {
            this.ship = ship;
        }


        protected override bool computeNewPosition()
        {
            //Missile meurt en haut de l'écran
            if (y > 1)
            {
                y--;
                return true;
            }
            ship.setMissileDestroyed();
            return false;

        }

        public override string getSprite()
        {
            return SPRITE;
        }

        protected override ConsoleColor getColor()
        {
            return ConsoleColor.Red;
        }
    }
}
