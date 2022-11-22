using System;

namespace nombre_complexe
{
    class Program
    {
        static void Main(string[] args)
        {
            double reel;
            double imaginaire;

            Console.WriteLine("Bienvenue dans les nombres complexes");
            Console.WriteLine("Que vaut la partie réel de votre complexe");
            reel = double.Parse(Console.ReadLine());
            Console.WriteLine("Que vaut la partie imaginaire de votre complexe");
            imaginaire = double.Parse(Console.ReadLine());

            nbreComplexe nbre = new nbreComplexe(reel, imaginaire);
        }
    }
}
