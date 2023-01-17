using System;

namespace heritage_ApprendTout
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant etudiant = new Etudiant(3, "rue de l'investiture,43", "Emmanuelle", "rue des chevaliers, 1", 5530, "Yvoir");
            Employe employer = new Employe(DateTime.Now, "pompier", "Philippe", "rue commerciale,102", 1945, "Courrière");
            Professeur prof = new Professeur("sociologie", "Mr Patate", "rue rogier, 69", 5530, "Godinne");
            Console.WriteLine(etudiant.FabriqueEtiq());
            Console.WriteLine(employer.FabriqueEtiq());
            Console.WriteLine(prof.FabriqueEtiq());
        }
    }
}
