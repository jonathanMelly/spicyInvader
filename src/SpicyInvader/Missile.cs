//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Description communes à tous les ennemis

namespace SpicyInvader
{
    public abstract class Missile
    {
        protected short xPosition;
        protected short yPosition;

        public Missile(short xPosition,short yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }

        public abstract string getSprite();



        public short getXPosition()
        {
            return xPosition;
        }
        public short getYPosition()
        {
            return yPosition;
        }
    }
}
