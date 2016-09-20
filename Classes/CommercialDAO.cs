using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes
{
     public class CommercialDAO
    {
        SqlConnection connect;
        public CommercialDAO(string connexion)
        {
            connect = new SqlConnection(connexion);
        }
        /// <summary>
        /// Methode de recherche de commerciaux dans la base de donnée associée
        /// </summary>
        /// <returns>Renvoie une liste de type Commercial</returns>
        public List<Commercial> List()
        {
            connect.Open();
            List<Commercial> liste = new List<Commercial>();
            SqlCommand requete = new SqlCommand("SELECT * FROM Commercial", connect);
            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                Commercial comm = new Commercial();
                comm.Id = Convert.ToInt32(lecture["code_commercial"]);
                comm.Nom = lecture["nom_commercial"].ToString();
                comm.Prenom = lecture["prenom_commercial"].ToString();
                comm.Mail = lecture["mail_commercial"].ToString();
                comm.Telephone = lecture["telephone_commercial"].ToString();
                comm.Affichage = comm.Nom + " " + comm.Prenom;
                liste.Add(comm);            
            }
            connect.Close();
            return liste;
        }
        /// <summary>
        /// Méthode de recherche d'un commercial à partir de son identifiant
        /// </summary>
        /// <param name="id">Identifiant du commercial</param>
        /// <returns>Renvoie une variable de type Commercial contenant les informations de la base de donnée</returns>
        public Commercial Find(int id)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("SELECT * FROM Commercial WHERE code_commercial = @id", connect);
            requete.Parameters.AddWithValue("@id", id);
            SqlDataReader lecture = requete.ExecuteReader();
            Commercial comm = new Commercial();
            if (lecture.Read())
            {
                comm.Id = Convert.ToInt32(lecture["code_commercial"]);
                comm.Nom = lecture["nom_commercial"].ToString();
                comm.Prenom = lecture["prenom_commercial"].ToString();
                comm.Mail = lecture["mail_commercial"].ToString();
                comm.Telephone = lecture["telephone_commercial"].ToString();
                comm.Affichage = comm.Nom + " " + comm.Prenom;
            }
            connect.Close();

            return comm;
        }
    }
}
