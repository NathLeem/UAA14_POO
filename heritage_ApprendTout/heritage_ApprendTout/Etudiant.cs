using System;
using System.Collections.Generic;
using System.Text;

namespace heritage_ApprendTout
{
    class Etudiant : Personne
    {
        protected int _annee;
        protected string _ad_Kot;

        public Etudiant(int annee,string ad_Kot,string nom, string adresse, int codePostal, string localite) : base(nom,adresse,codePostal,localite)
        {
            this._annee = annee;
            this._ad_Kot = ad_Kot;
        }
        public string FabriqueEtiq()
        {
            string etiquette = this._annee + "\n" + this._ad_Kot;
            return etiquette;
        }
    }
}
