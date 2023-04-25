using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guichet_bancaire.classes
{
    class Personne
    {
        protected string _nom;
        protected string _prenom;
        protected string _email;
        protected string _motDePasse;
        public Personne(string nom, string prenom, string email, string motDePasse)
        {
            _nom = nom;
            _prenom = prenom;
            _email = email;
            _motDePasse = motDePasse;
        }
    }
}
