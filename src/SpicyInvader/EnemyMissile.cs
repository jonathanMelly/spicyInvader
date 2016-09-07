//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

using System;

namespace SpicyInvader
{
    public class EnemyMissile : Missile
    {
        private Enemy enemy;
        public EnemyMissile(ConsoleWrapper console, short xPosition, short yPosition, Enemy enemy) : base(console, xPosition, yPosition)
        {
              this.enemy = enemy;
        }

        protected override ConsoleColor getColor()
        {
            return ConsoleColor.Red;
        }

        public override string getSprite()
        {
            return "°";
        }


        public void goToNextPosition(Ship ship)
        {
            this.erase();
            y++;

            if (x == ship.getX() && y == ship.getY())
            {
                //TODO perdre une vie
                //ship.
            }
            //Missile n'a pas touché  le vaisseau
            else if( y >= ship.getY())
            {
                enemy.missileMissed();
            }
            else
            {
                this.display();
            }
        }
    }
}