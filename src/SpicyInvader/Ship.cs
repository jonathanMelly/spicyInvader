//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Conteneur global du jeu

using System;

namespace SpicyInvader
{
    public class Ship
    {
        //Position du vaisseau sur l'axe horizontal (le zéro est tout à gauche de l'axe)
        private short xPosition;
        private readonly short rightLimit;

        //Dessin du vaisseau
        private const string SPRITE="├¤┤";

        /// <summary>
        /// Création d'un vaisseau avec une position et une limite de déplacement
        /// </summary>
        /// <param name="initialPosition"></param>
        /// <param name="rightLimit"></param>
        public Ship(short initialPosition,short rightLimit)
        {
            this.xPosition = initialPosition;
            this.rightLimit = rightLimit;
        }

        /// <summary>
        /// Lance un missile (si pas déjà un en cours)
        /// </summary>
        /// <returns>vrai si un nouveau missile a été lancé, faux s'il y en avait déjà un</returns>
        public bool fire()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Déplace le vaisseau sur la gauche (pour autant qu'il puisse encore)
        /// </summary>
        public void moveLeft()
        {
            if (xPosition > 0)
            {
                xPosition--;
            }
            
        }

        /// <summary>
        /// Déplace le vaisseau sur la droite (jusqu'à rightLimit)
        /// </summary>
        public void moveRight()
        {
            if (xPosition < rightLimit-SPRITE.Length)
            {
                xPosition++;
            }
        }

        //Accesseurs
        public short getPosition()
        {
            return xPosition;
        }

        public string getSprite()
        {
            return SPRITE;
        }
    }
}
