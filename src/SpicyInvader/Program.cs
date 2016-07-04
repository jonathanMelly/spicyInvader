using System;

namespace SpicyInvader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 20);


            Game game = new Game();
            
            game.setRenderingEngine(new ConsoleRendering());
            game.start();


            Console.ReadLine();
        }
    }
}
