using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_debut
{
    public struct Controller
    {
        public string AfficheData(DataSet donnees)
        {
            string infos = "";
            for (int i = 0; i < donnees.Tables[0].Rows.Count; i++)
            {
                infos += donnees.Tables[0].Rows[i]["Code client"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["Société"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["Contact"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["Adresse"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["Code postal"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["Ville"].ToString() + " | " + "\n";
            }
            return infos;
        }
    }
}