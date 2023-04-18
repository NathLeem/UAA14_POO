using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CourseLevriers
{
    class Parieur
    {
        string _nom = "";
        Pari _monPari = new Pari();
        int _cash;
        public Parieur(string nom, int cash)
        {
            _nom = nom;
            _cash = cash;
        }

        public void Parie(int valeurPari, int numChien)
        {
            
        }
        public void ResetPari()
        {
            
        }
        public void MajInfos()
        {

        }
    }
}
