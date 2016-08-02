//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

using System;

namespace SpicyInvader
{
    public class EnemyMissile : Missile
    {
        public EnemyMissile(ConsoleWrapper console,short xPosition, short yPosition) : base(console,xPosition, yPosition)
        {
        }

        protected override ConsoleColor getColor()
        {
            return ConsoleColor.Red;
        }

        public override string getSprite()
        {
            return "°";
        }


        protected override bool goToNextPosition(Enemy[] enemies)
        {
            throw new NotImplementedException();
        }
    }
}