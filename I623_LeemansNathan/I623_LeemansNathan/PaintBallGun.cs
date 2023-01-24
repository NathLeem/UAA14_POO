using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I623_LeemansNathan
{
    class PaintBallGun
    {
        private int _balle;
        private bool _chargeurVide;
        private int _chargeurCapacite;
        public PaintBallGun(int balle, bool chargeurVide, int chargeurCapacite)
        {
            this._balle = balle;
            this._chargeurVide = chargeurVide;
            this._chargeurCapacite = chargeurCapacite;
        }

        public void AfficheCapacite()
        {
            string texte = "Vous avez un total de " + this._balle + " balles dans votre poche et " + this._chargeurCapacite + " dans le chargeur \n";

            Console.WriteLine(texte);
        }

        public void Tirer(out string affiche)
        {
            affiche = "";
            if (_chargeurCapacite == 0)
            {
                affiche = "=> pas de balle dans le chargeur \n";
                this._chargeurVide = true;
            }
            else
            {
                if (this._chargeurVide == false)
                {
                    this._chargeurCapacite--;
                    affiche = "=> Tire effectué !\n";
                }

            }

            Console.WriteLine(affiche);
        }

        public int ReprendreBalle()
        {
            this._balle = this._balle + 30;

            return _balle;
        }

        public int Recharger()
        {
            string txtRecharge = "";
            if (this._balle >= 16)
            {
                if (this._chargeurVide == true)
                {
                    this._chargeurCapacite = this._chargeurCapacite + 16;
                    this._balle = this._balle - 16;
                }
                else
                {
                    this._chargeurCapacite = this._chargeurCapacite + this._balle;
                }
            }
            else
            {
                txtRecharge = "=> pas assez de balle dans votre poche\n";
                Console.WriteLine(txtRecharge);
            }
            this._chargeurVide = false;

            return _chargeurCapacite;
        }
    }
}
