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

        //Points pour un ennemi standard
        internal const int DEFAULT_REWARD = 20;

        private const int ENEMY_LINE_COUNT = 11;
        private const int LINES_OCTOPUS = 2;
        private const int LINES_MEDUSA = 2;
        private const int LINES_CRAB = 1;

        //TODO UFO

        //Elements du jeu
        private Level level;
        private Ship ship;
        private Enemy[] enemies = new Enemy[(LINES_OCTOPUS + LINES_MEDUSA + LINES_CRAB) * ENEMY_LINE_COUNT];

        ConsoleWrapper console;

        public Game(ConsoleWrapper console)
        {
            this.console = console;
        }

        public void start()
        {
            //Initilisation des objets utiles pour la boucle de jeu
            initialize();

            bool gameOver = false;

            //Compte les affichages
            int frame = 0;

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
                        ship.getMissile().goForward(enemies);
                    }
                }

                //Score
                console.setForegroundColor(ConsoleColor.White);
                console.setCursorPosition(0, 0);
                console.write("Score : " + ship.getScore());

                //Temporisation
                if (frame++ > int.MaxValue - 1)
                {
                    frame = 0;
                }
                System.Threading.Thread.Sleep(GAME_SPEED);

            }


        }


        public void initialize()
        {

            console.setWindowSize(50, 20);
            console.setCursorVisible(false);

            level = new Level();
            ship = new Ship(console);

            //Placement des objets initiaux
            ship.display();

            //Ennemis
            int initialY = 5;
            int initialX = (console.getWindowWidth() - ENEMY_LINE_COUNT) / 2;

            //Octopus
            int elements = 0;
            for (int i = 0; i < LINES_OCTOPUS; i++)
            {
                for (int j = 0; j < ENEMY_LINE_COUNT; j++)
                {
                    enemies[elements] = new Octopus(console, initialX + j, initialY + i);
                    enemies[elements].display();

                    elements++;
                }
            }

            /*
            for (int i = 0; i < LINES_MEDUSA; i++)
            {
                for (int j = 0; j < enemies.GetLength(1); j++)
                {
                    enemies[i, j] = new Medusa(initialX + j, initialY + i);
                    enemies[i, j].display();
                }
            }
            */
        }

    }
}
