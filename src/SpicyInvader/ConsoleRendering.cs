using System;

namespace SpicyInvader
{

    class ConsoleRendering : RenderingEngine
    {

        public void clear()
        {
            Console.Clear();
        }

        public void display(Enemy enemy)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Affichage du vaisseau dans la console
        /// </summary>
        /// <param name="ship">le vaisseau à dessiner</param>
        public void display(Ship ship)
        {
            //Vaisseau
            Console.SetCursorPosition(Convert.ToInt32(ship.getXPosition()), ship.getYPosition());
            Console.Write(ship.getSprite());
        }

        public void display(Missile missile)
        {
            Console.SetCursorPosition(missile.getXPosition(), missile.getYPosition());
            Console.Write(missile.getSprite());
        }

        public int getWindowHeight()
        {
            return Console.WindowHeight;
        }

        public int getWindowWidth()
        {
            return Console.WindowWidth;
        }

        public void refresh()
        {
            Console.Out.Flush();
        }
    }
}
