//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

namespace SpicyInvader
{
    /// <summary>
    /// Gestion des éléments communs à tous les ennemis
    /// </summary>
    public abstract class Enemy : StringDisplayable2D
    {
        

        public Enemy(ConsoleWrapper console,int x, int y) : base(console, x, y)
        {
            //Parent
        }

        public int getReward()
        {
            return Game.DEFAULT_REWARD;
        }
    }
}
