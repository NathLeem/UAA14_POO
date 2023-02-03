using System;
using System.Collections.Generic;
using System.Text;

namespace heritage_Animaux
{
    class Animal
    {
        protected bool _estConcours;
        protected string _nom;
        protected DateTime _dateNaissance;
        protected int _numPuce;
        protected int _taille;

        public Animal( bool estConcours, string nom, DateTime dateNaissance, int numPuce, int taille)
        {
            _nom = nom;
            _dateNaissance = dateNaissance;
            _numPuce = numPuce;
            _taille = taille;
        }
        public string Dormir()
        {
            string DorAffiche = "rrrrrr rrrr";
            return DorAffiche;
        }
        public string Manger()
        {
            string mangerAffiche = "Miam miam";
            return mangerAffiche;
        }
        public string EstConcours()
        {
            string concour = "";
            if (_estConcours == true)
            {
                concour = _nom + " est un animal de concours";
            }
            else
            {
                concour = _nom + " n'est pas un animal de concours";
            }
            return concour;

        }
    }
}
