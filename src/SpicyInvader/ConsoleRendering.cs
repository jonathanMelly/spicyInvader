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
            Console.SetCursorPosition(Convert.ToInt32(ship.getPosition()), 50);
            Console.Write(ship.getSprite());
        }

        public void display(Missile missile)
        {
            throw new NotImplementedException();
        }

        public int getWindowHeight()
        {
            return Console.WindowHeight;
        }

        public int getWindowWidth()
        {
            return Console.WindowWidth;
        }
    }
}
