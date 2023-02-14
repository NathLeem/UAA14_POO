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

        public bool RechercheClientSociete(string nomSociete,out DataSet ds)
        {
            OleDbConnection maConnexion = new OleDbConnection(DefinirCheminBD());
            string query = "SELECT * FROM Clients WHERE Société =\"" + nomSociete + "\";";
            ds = new DataSet();
            bool verif = false;
            try
            {
                maConnexion.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(query, maConnexion);
                da.Fill(ds, "mesDonnees");
                if (ds.Tables[0].Rows.Count != 0)
                {
                    verif = true;
                }
                
                maConnexion.Close();
                                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return verif;
        }

        public string MAJDonnees(string nomMessager)
        {
            string maj = "";
            OleDbConnection maConnexion = new OleDbConnection(DefinirCheminBD());
            string query = "UPDATE table SET Telephone=@telephone WHERE NomDuMessager =\"" + nomMessager + "\";";
            OleDbCommand upCommand = new OleDbCommand(query, maConnexion);
            upCommand.Parameters.AddWithValue("@telephone", nomMessager);
            upCommand.ExecuteNonQuery();

            return maj;
        }
        public string AjoutDonnees()
        {
            string ajout = "";
            OleDbConnection maConnexion = new OleDbConnection(DefinirCheminBD());
            string query = "INSERT INTO table(liste de champs séparés par des virgules) VALUES(liste de paramètres séparés par des virgules)";

            return ajout;
        }
    }
}