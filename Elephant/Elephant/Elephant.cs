using System;
using System.Collections.Generic;
using System.Text;

namespace Elephant
{
    class Elephant
    {
        private string _nom;
        private uint _tailleOreilles;

        public Elephant(string nom, uint tailleOreilles)
        {
            _nom = nom;
            _tailleOreilles = tailleOreilles;
        }

        public string AfficheQuiJeSuis()
        {
            string affichage;

            affichage = "Je m'appelle " + _nom + ".\n" + "Mes oreilles mesurent " + _tailleOreilles + "cm.";

            return affichage;
        }
    }
}