using System;
using System.Collections.Generic;
using System.Text;

namespace heritage_ApprendTout
{
    class Professeur : Personne
    {
        protected string _specialisation;

        public Professeur(string specialisation ,string nom, string adresse, int codePostal, string localite) : base(nom, adresse, codePostal, localite)
        {

        }
    }
}
