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

        public FriendlyMissile(ConsoleWrapper console, Ship ship, short x, short y) : base(console, x, y)
        {
            this.ship = ship;
        }


        protected override bool goToNextPosition(Enemy[] enemies)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                Enemy enemy = enemies[i];

                //Ennemi touché
                if (enemy != null && enemy.getX() == x && enemy.getY() == y)
                {
                    ship.addScore(enemy.getReward());
                    enemy.erase();
                    enemies[i] = null;

                    missileExploded();
                    return false;
                }
            }

            //Missile meurt en haut de l'écran
            if (y > 0)
            {
                y--;
                return true;
            }
            else
            {
                missileExploded();
                return false;
            }

        }

        private void missileExploded()
        {
            ship.setMissileExploded();
            
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
