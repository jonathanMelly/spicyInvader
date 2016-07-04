//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

namespace SpicyInvader
{
    /// <summary>
    /// Gestion des éléments communs à tous les ennemis
    /// </summary>
    public class Enemy : EnemyMissile
    {
        public Enemy(short xPosition, short yPosition) : base(xPosition, yPosition)
        {
        }
    }
}
