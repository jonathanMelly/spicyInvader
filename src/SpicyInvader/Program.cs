using System;

namespace SpicyInvader
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game(new MsDosConsole());
            game.start();


            Console.ReadLine();
        }
    }
}
