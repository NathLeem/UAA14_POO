using System;

namespace ExPremiereApprochePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            chienBis[] mesChiens = new chienBis[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Quel est le nom de votre chien ?");
                string nomChien = Console.ReadLine();
                Console.WriteLine("Quel est l'âge de votre chien ?");
                uint ageChien = uint.Parse(Console.ReadLine());
                Console.WriteLine("Quel est la race de votre chien ?");
                string raceChien = Console.ReadLine();

                mesChiens[i] = new chienBis(nomChien, ageChien, raceChien);
                Console.WriteLine(mesChiens[i].AfficheCaracteristique());

                Console.WriteLine(mesChiens[i].CalculeAgeMoyenne());
            }
        }
    }
}
