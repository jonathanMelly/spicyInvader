//Lieu : ETML
//Date : 2016
//Auteur : JMY/CHA
//Description : Interface pour le rendu

namespace SpicyInvader
{
    /// <summary>
    /// Découplage du rendu pour facilement porter vers d'autres implémentations que la version Console
    /// </summary>
    interface RenderingEngine
    {
        void clear();

        int getWindowWidth();
        int getWindowHeight();

        void display(Missile missile);
        void display(Ship ship);
        void display(Enemy enemy);
    }
}
