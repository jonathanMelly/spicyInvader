//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Conteneur global du jeu

using System;

namespace SpicyInvader
{
    public class Ship : StringDisplayable2D
    {
        //Position du vaisseau sur l'axe horizontal (le zéro est tout à gauche de l'axe)
        private readonly short rightLimit;

        //Dessin du vaisseau
        private const string SPRITE = "├¤┤";

        private FriendlyMissile missile;

        private int score = 0;


        /// <summary>
        /// Création d'un vaisseau avec une position et une limite de déplacement
        /// </summary>
        /// <param name="rightLimit"></param>
        public Ship(ConsoleWrapper console) : base(console, console.getWindowWidth()/2, console.getWindowHeight()-1)
        {
            this.rightLimit = Convert.ToInt16(console.getWindowWidth());
        }

        internal void addScore(int points)
        {
            score += points;
        }

        internal void setMissileExploded()
        {
            missile = null;
        }

        /// <summary>
        /// Lance un missile (si pas déjà un en cours)
        /// </summary>
        /// <returns>vrai si un nouveau missile a été lancé, faux s'il y en avait déjà un</returns>
        public bool fire()
        {
            if (missile == null)
            {
                missile = new FriendlyMissile(console,this, Convert.ToInt16(x + SPRITE.Length / 2),
                                              Convert.ToInt16(y - 1));

                missile.display();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Déplace le vaisseau sur la gauche (pour autant qu'il puisse encore)
        /// </summary>
        public void moveLeft()
        {
            if (x > 0)
            {
                erase();
                x--;
                display();
            }

        }

        /// <summary>
        /// Déplace le vaisseau sur la droite (jusqu'à rightLimit)
        /// </summary>
        public void moveRight()
        {
            if (x < rightLimit - SPRITE.Length)
            {
                erase();
                x++;
            }
            display();
        }

        public override string getSprite()
        {
            return SPRITE;
        }

        protected override ConsoleColor getColor()
        {
            return ConsoleColor.Green;
        }

        //Accesseurs
        public bool isMissileFired()
        {
            return missile != null;
        }

        public FriendlyMissile getMissile()
        {
            return missile;
        }

        public int getScore()
        {
            return score;
        }


    }
}
