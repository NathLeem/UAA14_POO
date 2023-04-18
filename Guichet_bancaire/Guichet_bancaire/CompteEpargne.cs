using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guichet_bancaire
{
    class CompteEpargne : CompteBancaire
    {
        private int _tauxInteret;

        public CompteEpargne(string numero, int solde, int tauxInteret) : base(numero, solde)
        {
            _tauxInteret = tauxInteret;
        }

        public override string Retrait(int monnaie)
        {
            throw new NotImplementedException();
        }
        public override int Transfere(int monnaie, out string messageRetrait)
        {
            _solde = _solde - monnaie;
            messageRetrait = "Transfert effectué vers le compte courant";
            

            return _solde;
        }
        public override string Ajout(int monnaie)
        {
            string messageAjout = "";


            return messageAjout;
        }
    }
}
