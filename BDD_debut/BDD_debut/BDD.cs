using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;


namespace BDD_debut
{
    public struct BDD
    {
        public string DefinirCheminBD()
        {
            // Début de chemin identique pour toute base de type ACCESS & chemin relatif vers la bdd

            string CheminBDRelatif = System.IO.Directory.GetCurrentDirectory() + "\\Comptoirs.accdb";

            return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + CheminBDRelatif;
        }

        public void RechercheClientSociete(string nomSociete)
        {
            OleDbConnection maConnexion = new OleDbConnection(DefinirCheminBD());
            string query = "SELECT * FROM Clients WHERE Société =\"" + nomSociete + "\";";
            DataSet ds = new DataSet();
            try
            {
                maConnexion.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(query, maConnexion);
                da.Fill(ds, "mesDonnees");

                

                maConnexion.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
    }
}