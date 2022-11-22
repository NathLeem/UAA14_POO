using System;
using System.Collections.Generic;
using System.Text;

namespace nombre_complexe
{
    class nbreComplexe
    {
        private double _reel;
        private double _imaginaire;

        public double Reel
        {
            get
            {
                return _reel;
            }
            set
            {
                _reel = value;
            }
        }
        public double Imaginaire
        {
            get
            {
                return _imaginaire;
            }
            set
            {
                _imaginaire = value;
            }
        }

        public string AfficheComplexe()
        {
            string Affiche;
            Affiche = "(" + _reel + "," + _imaginaire + ")";
            return Affiche;
        }
    }
}
