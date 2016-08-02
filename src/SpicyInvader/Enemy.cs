//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

using System;

namespace SpicyInvader
{
    /// <summary>
    /// Gestion des éléments communs à tous les ennemis
    /// </summary>
    public abstract class Enemy : StringDisplayable2D
    {

        Missile missile;

        public Enemy(ConsoleWrapper console,int x, int y) : base(console, x, y)
        {
            //Parent
        }

        /// <summary>
        /// Tire un missile ennemi
        /// </summary>
        /// <returns></returns>
        public bool fire()
        {
            if (missile == null)
            {
                missile = new EnemyMissile(console, Convert.ToInt16(x),Convert.ToInt16(y + 1));

                missile.display();
                return true;
            }
            return false;
        }

        public bool canFire()
        {
            return missile == null;
        }

        public int getReward()
        {
            return Game.DEFAULT_REWARD;
        }
    }
}
