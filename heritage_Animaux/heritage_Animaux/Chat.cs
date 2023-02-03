using System;
using System.Collections.Generic;
using System.Text;

namespace heritage_Animaux
{
    class Chat : Animal
    {
        public Chat(bool estConcours, string nom, DateTime dateNaissance, int numPuce, int taille) : base(estConcours,nom,dateNaissance,numPuce,taille)
        {
            _estConcours = estConcours;
            _nom = nom;
            _dateNaissance = dateNaissance;
            _numPuce = numPuce;
            _taille = taille;
        }
        public string Miauler()
        {
            string texteAffiche = "Miaou miaou";
            return texteAffiche;
        }
    }
}
