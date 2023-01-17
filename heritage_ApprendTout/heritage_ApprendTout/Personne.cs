using System;
using System.Collections.Generic;
using System.Text;

namespace heritage_ApprendTout
{
    class Personne
    {
        protected string _nom;
        protected string _adresse;
        protected int _codePostal;
        protected string _localite;

        public Personne(string nom, string adresse, int codePostal, string localite)
        {
            this._nom = nom;
            this._adresse = adresse;
            this._codePostal = codePostal;
            this._localite = localite;
        }
        public string FabriqueEtiq()

        {
            string etiquette = this._nom + "\n" + this._adresse + "\n" + this._codePostal + "\n" + this._localite + "\n";
            return etiquette;
        }
    }
}
