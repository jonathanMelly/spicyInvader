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
        private RenderingEngine renderingEngine;

        public void start()
        {
            //
            initialize();

            bool gameOver = false;

            //Compte les affichages
            int frame = 0;

            //Affichage initial
            renderingEngine.display(ship);

            while (!gameOver)
            {

                //debug
                //Console.SetCursorPosition(5, 5);
                //Console.Write("Score : "+i++);

                //Mise à jour de l'affichage
                //renderingEngine.refresh();




                //Mouvement du vaisseau selon entrée utilisateur
                bool shipMoved = false;
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            ship.moveLeft();
                            shipMoved = true;
                            break;

                        case ConsoleKey.RightArrow:
                            ship.moveRight();
                            shipMoved = true;
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
                bool friendlyMissileMoved = false;
                if (frame % MISSILE_SPEED == 0)
                {
                    if (ship.isMissileFired())
                    {
                        friendlyMissileMoved = ship.getMissile().goForward();

                        //Missile détruit
                        if (!friendlyMissileMoved)
                        {
                            drawObjects();
                        }
                    }
                }


                //Mise à jour de l'affichage
                if (shipMoved || friendlyMissileMoved)
                {
                    drawObjects();
                }

                //Temporisation
                if (frame++ > int.MaxValue - 1)
                {
                    frame = 0;
                }
                System.Threading.Thread.Sleep(GAME_SPEED);

            }


        }

        //TODO draw only 1 time per frame
        private void drawObjects()
        {
            //Ecran à refaire
            renderingEngine.clear();

            //Redessine le vaisseau
            renderingEngine.display(ship);

            //Redessine si besoin le missile
            if (ship.isMissileFired())
            {
                renderingEngine.display(ship.getMissile());
            }
        }

        private void initialize()
        {
            if (renderingEngine == null)
            {
                throw new ApplicationException("No rendering engine defined.\nPlease call method 'setRenderingEngine'");
            }

            level = new Level();
            ship = new Ship(Convert.ToInt16(renderingEngine.getWindowWidth() / 2),
                            Convert.ToInt16(renderingEngine.getWindowHeight()),
                            Convert.ToInt16(renderingEngine.getWindowWidth())
                            );
        }

        public void setRenderingEngine(RenderingEngine renderingEngine)
        {
            this.renderingEngine = renderingEngine;
        }
    }
}
