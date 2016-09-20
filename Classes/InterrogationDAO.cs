using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Classes
{
    public class InterrogationDAO
    {
        SqlConnection connect;
        public InterrogationDAO(string phrase)
        {
            connect = new SqlConnection(phrase);
        }
        public string CATotal()
        {
            string resultat;
            connect.Open();
            SqlCommand requete = new SqlCommand();
            requete.Connection = connect;
            requete.CommandType = CommandType.StoredProcedure;
            requete.CommandText = "chiffre_affaire_total";
            resultat = "Chiffre d'affaire total : " + requete.ExecuteScalar().ToString();
            connect.Close();
            return resultat;
        }

        public List<string> CA_fournisseur()
        {
            connect.Open();
            SqlCommand requete = new SqlCommand();
            requete.Connection = connect;
            requete.CommandType = CommandType.StoredProcedure;
            requete.CommandText = "chiffre_affaire_fournisseur";
            SqlDataReader lecture = requete.ExecuteReader();
            List<string> liste = new List<string>();
            while (lecture.Read())
            {
                string element;
                element = "Nom du fournisseur " + lecture["nom_fournisseur"].ToString() + " Montant du CA : " + lecture["Chiffre d'affaire"].ToString();
                liste.Add(element);
            }

            connect.Close();
            return liste;
        }

        public List<string> CA_client()
        {
            connect.Open();
            List<string> liste = new List<string>();
            SqlCommand requete = new SqlCommand();
            requete.Connection = connect;
            requete.CommandType = CommandType.StoredProcedure;
            requete.CommandText = "chiffre_affaire_client";
            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                string element = "";
                if (Convert.ToBoolean(lecture["type_client"]))
                {
                    element = "Professionnel Montant CA : " + Convert.ToDecimal(lecture["Chiffre d'affaire"]);
                }
                else
                {
                    element = "Particulier Montant CA : " + Convert.ToDecimal(lecture["Chiffre d'affaire"]);
                }
                liste.Add(element);
            }
            connect.Close();
            return liste;
        }
    }
}
