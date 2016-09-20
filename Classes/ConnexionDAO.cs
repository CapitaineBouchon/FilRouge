using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes
{
    public class ConnexionDAO
    {
        SqlConnection connect;
        public ConnexionDAO(string connexion)
        {
            connect = new SqlConnection(connexion);
        }

        public bool TestConnexion(Connexion logs)
        {
            bool test;
            connect.Open();
            SqlCommand requete = new SqlCommand("SELECT * FROM Connexion WHERE login_connexion=@login AND mdp_connexion=@mdp", connect);
            requete.Parameters.AddWithValue("@login", logs.Login);
            requete.Parameters.AddWithValue("@mdp", logs.MdP);
            SqlDataReader lecture = requete.ExecuteReader();
            if (lecture.Read())
            {
                test = true;
            }
            else
            {
                test = false;
            }
            connect.Close();
            return test;
        }

        public Connexion Find(Connexion logs)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("SELECT * FROM Connexion WHERE login_connexion=@login AND mdp_connexion=@mdp", connect);
            requete.Parameters.AddWithValue("@login", logs.Login);
            requete.Parameters.AddWithValue("@mdp", logs.MdP);
            SqlDataReader lecture = requete.ExecuteReader();
            Connexion info = new Connexion();
            if (lecture.Read())
            {
                info.IdCommercial = Convert.ToInt32(lecture["id_commercial_connexion"]);                
            }
            connect.Close();
            return info;
        }
    }
}
