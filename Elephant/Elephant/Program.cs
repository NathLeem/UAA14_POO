
using System;

namespace Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant1 = new Elephant("Zazou", 150);
            Elephant elephant2 = new Elephant("Titi",100);
            int chiffres;
            string affichage = "";

            Console.WriteLine("Bienvenue \n Tapez : \n 1 pour afficher les informations de Zazou, \n 2 pour Titi,\n 3 pour les échanger,");
            chiffres = int.Parse(Console.ReadLine());

            if (chiffres == 1)
            {
                affichage = elephant1.AfficheQuiJeSuis();
            }
            else if (chiffres == 2)
            {
                affichage = elephant2.AfficheQuiJeSuis();
            }
            Console.WriteLine(affichage);
            Console.ReadLine();
        }
    }
}