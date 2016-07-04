//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

using System;

namespace SpicyInvader
{
    public class Octopus : Enemy
    {
        private const string SPRITE = "ıÀ";

        public Octopus(short xPosition, short yPosition) : base(xPosition, yPosition)
        {
            //Parent
        }

        public override string getSprite()
        {
            return SPRITE;
        }
    }
}
