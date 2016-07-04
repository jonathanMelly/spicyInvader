//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

using System;

namespace SpicyInvader
{
    public class EnemyMissile : Missile
    {
        public EnemyMissile(short xPosition, short yPosition) : base(xPosition, yPosition)
        {
        }

        protected override ConsoleColor getColor()
        {
            throw new NotImplementedException();
        }

        public override string getSprite()
        {
            throw new NotImplementedException();
        }


        protected override bool computeNewPosition()
        {
            throw new NotImplementedException();
        }
    }
}