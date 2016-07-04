//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Conteneur global du jeu

using System;
namespace SpicyInvader
{
    /// <summary>
    /// Instanciation des objets du jeu, gestion de fin
    /// </summary>
    public class Game
    {
        //Configuration

        //Vitesse horizontale du vaisseau
        public const byte SHIP_SPEED = 1;

        //Elements du jeu
        private Level level;
        private Ship ship;
        private RenderingEngine renderingEngine;

        public Game()
        {
            renderingEngine = new ConsoleRendering();

            level = new Level();
            ship = new Ship(Convert.ToInt16(renderingEngine.getWindowWidth() / 2), 
                            Convert.ToInt16(renderingEngine.getWindowWidth())
                            );
        }

        public void start()
        {
            while(true)
            {
                //Nettoyage de l'écran pour l'ancien frame
                renderingEngine.clear();

                //Affichage des éléments
                renderingEngine.display(ship);

                //Mouvement du vaisseau selon entrée utilisateur
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch(keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        ship.moveLeft();
                        break;

                    case ConsoleKey.RightArrow:
                        ship.moveRight();
                        break;

                    default:
                        //Rien à faire pour les autres touches
                        break;
                }
            }
            
        }
    }
}
