using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guichet_bancaire
{
    abstract class CompteBancaire
    {
        protected string _numero;
        protected int _solde;
        public CompteBancaire(string numero,int solde)
        {
            _solde = solde;
            _numero = numero;
        }
        public abstract string Retrait(int monnaie);
        public abstract int Transfere(int monnaie, out string messageRetrait);
        public abstract string Ajout(int monnaie);
    }
}