//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

namespace SpicyInvader
{
    /// <summary>
    /// Gestion des éléments communs à tous les ennemis
    /// </summary>
    public abstract class Enemy
    {
        short xPosition;
        short yPosition;

        public abstract string getSprite();

        public Enemy(short xPosition, short yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }
    }
}
