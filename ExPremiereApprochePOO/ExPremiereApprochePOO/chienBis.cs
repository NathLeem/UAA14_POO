using System;
using System.Collections.Generic;
using System.Text;

namespace ExPremiereApprochePOO
{
    class chienBis
    {
        private string _nom;
        private uint _age;
        private string _race;

        public chienBis(string _nom, uint _age, string _race)
        { 
            this._nom = _nom;
            this._age = _age;
            this._race = _race;
        }

        private uint valueAge;
        public uint Age
        {
            get 
            {
                return _age;
            }
            set 
            {
                if (value>0)
                {
                    _age = valueAge;
                } 
            }
        }

        private string valueNom;
        public string Nom
        { 
            get
            {
                return _nom;
            }
            set
            {
                _nom = valueNom;
            }
        }

        private string valueRace;

        public string Race
        {
            get
            {
                return _race; 
            }
            set 
            { 
                _race = valueRace;
            }
        }


        public string AfficheCaracteristique()
        {
            string phrase = "Nom: " + this._nom + " Age: " + this._age + " Race: " + this._race;
            return phrase;
        }

        public string CalculeAgeMoyenne()
        {
            uint moyenne = (chienBis[i] + chienBis[i+1] + chienBis[i+2] ) / 3;
            return moyenne;
        }
    }
}
