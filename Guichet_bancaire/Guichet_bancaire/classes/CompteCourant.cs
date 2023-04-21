using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guichet_bancaire
{
    class CompteCourant : CompteBancaire
    {
        private int _decouvertMax;

        public CompteCourant(string numero, int solde, int decouvertMax) : base(numero, solde)
        {
            _decouvertMax = decouvertMax;
        }
        public override string Retrait(int monnaie)
        {
            string messageRetrait = "";
            if (_solde >= _decouvertMax)
            {
                _solde = _solde - monnaie;
                messageRetrait = "Retrait du compte éffectué";
            }
            else
            {
                messageRetrait = "Votre compte ne contient pas assez pour faire un virement";
            }

            return messageRetrait;
        }
        public override int Transfere(int monnaie, out string messageRetrait)
        {
            _solde = _solde + monnaie;
            messageRetrait = "Virement effectué vers le compte courant";

            return _solde;
        }
        public override string Ajout(int monnaie)
        {
            _solde = _solde + monnaie;
            string messageAjout = "Virement sur le compte courant éffectué";

            return messageAjout;
        }
    }
}