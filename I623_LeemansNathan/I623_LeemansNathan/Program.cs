using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I623_LeemansNathan
{
    class Program
    {
        static void Main(string[] args)
        {
            string lettre = "";

            PaintBallGun fusil = new PaintBallGun(30, true, 0);

            Console.WriteLine("Bienvenu dans ce jeu de tir ... Vous démarrez avec 30 balles\n =========================================");

            while (lettre != "q")
            {
                fusil.AfficheCapacite();
                Console.WriteLine("Espace pour tirer \n r pour recharger \n + pour reprendre des munitions \n q pour quitter \n");
                lettre = Console.ReadLine();
                if (lettre == "r")
                {
                    fusil.Recharger();
                }
                if (lettre == " ")
                {
                    fusil.Tirer(out string affiche);
                }
                if (lettre == "+")
                {
                    fusil.ReprendreBalle();
                }
            }
        }
    }
}
