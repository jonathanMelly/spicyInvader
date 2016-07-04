//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

using System;

namespace SpicyInvader
{
    public class Octopus : Enemy
    {
        private const string SPRITE = "o";

        public Octopus(ConsoleWrapper console, int xPosition, int yPosition) : base(console, xPosition, yPosition)
        {
            //Parent
        }

        public override string getSprite()
        {
            return SPRITE;
        }

        protected override ConsoleColor getColor()
        {
            return ConsoleColor.Gray;
        }
    }
}
