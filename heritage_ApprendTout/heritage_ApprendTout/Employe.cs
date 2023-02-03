using System;
using System.Collections.Generic;
using System.Text;

namespace heritage_ApprendTout
{
    class Employe : Personne
    {
        protected DateTime _dateEmbauche;
        protected string _fonction;

        public Employe(DateTime dateEmbauche, string fonction, string nom, string adresse, int codePostal, string localite) : base(nom, adresse, codePostal, localite)
        {
            this._dateEmbauche = dateEmbauche;
            this._fonction = fonction;
        }
        public string FabriqueEtiq()
        {
            string etiquette = this._nom + "\n" + this._fonction + "\n" + this._dateEmbauche;
            return etiquette;
        }
    }
}