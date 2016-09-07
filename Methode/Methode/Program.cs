using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titre
            Console.WriteLine("Programme hyper utile");

            //Saisie par l'utilisateur
            int size = askValue();

            //Algorithme
            showNumbers(size);

            //Fin du programme
            Console.WriteLine("Appuyer sur une touche pour quitter");
            Console.ReadKey();
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="size">Taille à afficher</param>
        private static void showNumbers(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("i:" + i);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <returns>retourne la valeur entière saisie par l'utilisateur</returns>
        private static int askValue()
        {
            Console.Write("Veuillez saisir une valeur:");
            int size = Convert.ToInt32(Console.ReadLine());
            return size;
        }
    }
}
