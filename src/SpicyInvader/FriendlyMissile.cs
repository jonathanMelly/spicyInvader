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

        public FriendlyMissile(Ship ship,short xPosition, short yPosition) : base(xPosition, yPosition)
        {
            this.ship = ship;
        }

        /// <summary>
        /// Avance le missile à son prochain emplacement
        /// </summary>
        public bool goForward()
        {
            //Missile meurt en haut de l'écran
            if(yPosition>0)
            {
                yPosition--;
                return true;
            }
            ship.setMissileDestroyed();
            return false;
            
        }

        public override string getSprite()
        {
            return SPRITE;
        }

    }
}
