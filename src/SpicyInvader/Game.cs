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

        //Vitesse du jeu, ATTENTION ceci est dépendant du CPU et à ajuster selon la machine cible
        private const int GAME_SPEED = 25;

        //Inversément proportionnel
        private const int MISSILE_SPEED = 4;

        //Elements du jeu
        private Level level;
        private Ship ship;

        public void start()
        {
            //Initilisation des objets utiles pour la boucle de jeu
            initialize();

            bool gameOver = false;

            //Compte les affichages
            int frame = 0;

            //Affichage initial
            ship.display();

            while (!gameOver)
            {

                //Mouvement du vaisseau selon entrée utilisateur
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            ship.moveLeft();
                            break;

                        case ConsoleKey.RightArrow:
                            ship.moveRight();
                            break;

                        case ConsoleKey.Spacebar:
                            ship.fire();
                            break;

                        default:
                            //Rien à faire pour les autres touches
                            break;
                    }

                    

                }

                //Mouvement des ennemis

                //Mouvement du missile ami
                if (frame % MISSILE_SPEED == 0)
                {
                    if (ship.isMissileFired())
                    {
                        ship.getMissile().goForward();
                    }
                }


                //Temporisation
                if (frame++ > int.MaxValue - 1)
                {
                    frame = 0;
                }
                System.Threading.Thread.Sleep(GAME_SPEED);

            }


        }


        private void initialize()
        {

            Console.SetWindowSize(50, 20);
            Console.CursorVisible = false;

            level = new Level();
            ship = new Ship(Console.WindowWidth / 2,
                            Console.WindowHeight,
                            Console.WindowWidth);
        }

    }
}
