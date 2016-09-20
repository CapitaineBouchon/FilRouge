using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes
{
    public class ClientDAO
    {
        SqlConnection connect;
        /// <summary>
        /// Fonction de déclaration du DAO
        /// </summary>
        /// <param name="chaine">Paramètre de connexion à la base de donnée</param>
        public ClientDAO(string chaine)
        {
            connect = new SqlConnection(chaine);
        }

        /// <summary>
        /// Fonction de recherche de client dans la base de donnée
        /// </summary>
        /// <returns>Retourne une liste de Client</returns>
        public List<Client> List()
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("SELECT * FROM Client", connect);
            SqlDataReader lecture = requete.ExecuteReader();
            List<Client> maliste = new List<Client>();
            while (lecture.Read())
            {
                Client cli = new Client();
                cli.Id = (int)lecture["code_client"];
                cli.Nom = lecture["nom_client"].ToString();
                cli.Type = Convert.ToBoolean(lecture["type_client"]);
                cli.Adresse = lecture["adresse_client"].ToString();
                cli.CodePostal = lecture["code_postal_client"].ToString();
                cli.Ville = lecture["ville_client"].ToString();
                cli.Actif = Convert.ToBoolean(lecture["actif_client"]);
                maliste.Add(cli);
            }
            lecture.Close();
            connect.Close();
            return maliste;
        }

        /// <summary>
        /// Fonction de recherches de client en fonctions de paramètres entrés par l'utilisateur.
        /// </summary>
        /// <param name="request">Requete composé lors de la saisie par l'utilisateur</param>
        /// <returns>Retourne une liste de type Client</returns>
        public List<Client> Search(string request)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("SELECT * FROM Client WHERE actif_client = 1 " + request, connect);
            SqlDataReader lecture = requete.ExecuteReader();

            List<Client> maliste = new List<Client>();
            while (lecture.Read())
            {
                Client cli = new Client();
                cli.Id = (int)lecture["code_client"];
                cli.Nom = lecture["nom_client"].ToString();
                cli.Type = Convert.ToBoolean(lecture["type_client"]);
                cli.Adresse = lecture["adresse_client"].ToString();
                cli.CodePostal = lecture["code_postal_client"].ToString();
                cli.Ville = lecture["ville_client"].ToString();
                cli.Actif = Convert.ToBoolean(lecture["actif_client"]);
                maliste.Add(cli);
            }
            lecture.Close();
            connect.Close();
            return maliste;
        }

        /// <summary>
        /// Fonction de recherche d'informations sur un professionnel
        /// </summary>
        /// <param name="id">valeur de de l'identifiant client</param>
        /// <returns>Retourne un resultat de type Professionnel</returns>
        public Professionnel findPro(int id)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("SELECT * FROM Client WHERE code_client ="+id , connect);
            SqlDataReader lecture = requete.ExecuteReader();
            Professionnel cli = new Professionnel();
            if (lecture.Read())
            {
                cli.Id = (int)lecture["code_client"];
                cli.Nom = lecture["nom_client"].ToString();
                cli.Siret = lecture["siret_client"].ToString();
                cli.Domaine = lecture["domaine_client"].ToString();
                cli.Type = Convert.ToBoolean(lecture["type_client"]);
                cli.Adresse = lecture["adresse_client"].ToString();
                cli.Complement = lecture["complement_client"].ToString();
                cli.CodePostal = lecture["code_postal_client"].ToString();
                cli.Ville = lecture["ville_client"].ToString();
                cli.Telephone = lecture["telephone_client"].ToString();
                cli.Portable = lecture["portable_client"].ToString();
                cli.Mail = lecture["mail_client"].ToString();
                cli.Coefficient = Convert.ToDecimal(lecture["coefficient_client"]);
                cli.AdresseLivraison = lecture["adresse_livraison_client"].ToString();
                cli.ComplementLivraison = lecture["complement_livraison_client"].ToString();
                cli.CodePostalLivraison = lecture["code_postal_livraison_client"].ToString();
                cli.VilleLivraison = lecture["ville_livraison"].ToString();
                cli.AdresseFacturation = lecture["adresse_facturation"].ToString();
                cli.ComplementFacturation = lecture["complement_facturation"].ToString();
                cli.CodePostalFacturation = lecture["code_postal_facturation"].ToString();
                cli.VilleFacturation = lecture["ville_facturation"].ToString();
                cli.Actif = Convert.ToBoolean(lecture["actif_client"]);
                cli.idCommercial = (int)lecture["code_commercial_client"];
            }
            connect.Close();
            return cli;
        }        
        /// <summary>
        /// Fonction de mise a jour d'une fiche client Professionnel
        /// </summary>
        /// <param name="pro">Contient les nouvelles informations à envoyer</param>
        public void UpdatePro(Professionnel pro)
        {
            connect.Open();
            SqlCommand requeteClient = new SqlCommand("UPDATE Client SET code_commercial_client=@idCommercial, nom_client=@nom, siret_client=@siret, domaine_client=@domaine, type_client=@type, adresse_client=@adresse, complement_client=@complement, code_postal_client=@codepostal, ville_client=@ville, telephone_client=@telephone, portable_client=@portable, mail_client=@mail, coefficient_client=@coefficient, adresse_livraison_client=@adresseliv, complement_livraison_client=@complementliv, code_postal_livraison_client=@codepostalliv, ville_livraison=@villeliv, adresse_facturation=@adressefac, complement_facturation=@complementfac, code_postal_facturation=@codepostalfac, ville_facturation=@villefac WHERE code_client=@id", connect);
            requeteClient.Parameters.AddWithValue("@nom" , pro.Nom);
            requeteClient.Parameters.AddWithValue("@siret", pro.Siret);
            requeteClient.Parameters.AddWithValue("@domaine", pro.Domaine);
            requeteClient.Parameters.AddWithValue("@type", pro.Type);
            requeteClient.Parameters.AddWithValue("@adresse", pro.Adresse);
            requeteClient.Parameters.AddWithValue("@complement", pro.Complement);
            requeteClient.Parameters.AddWithValue("@codepostal", pro.CodePostal);
            requeteClient.Parameters.AddWithValue("@ville", pro.Ville);
            requeteClient.Parameters.AddWithValue("@telephone", pro.Telephone);
            requeteClient.Parameters.AddWithValue("@portable", pro.Portable);
            requeteClient.Parameters.AddWithValue("@mail", pro.Mail);
            requeteClient.Parameters.AddWithValue("@coefficient", pro.Coefficient);
            requeteClient.Parameters.AddWithValue("@id", pro.Id);
            requeteClient.Parameters.AddWithValue("@adresseliv", pro.AdresseLivraison);
            requeteClient.Parameters.AddWithValue("@complementliv", pro.ComplementLivraison);
            requeteClient.Parameters.AddWithValue("@codepostalliv", pro.CodePostalLivraison);
            requeteClient.Parameters.AddWithValue("@villeliv", pro.VilleLivraison);
            requeteClient.Parameters.AddWithValue("@adressefac", pro.AdresseFacturation);
            requeteClient.Parameters.AddWithValue("@complementfac", pro.ComplementFacturation);
            requeteClient.Parameters.AddWithValue("@codepostalfac", pro.CodePostalFacturation);
            requeteClient.Parameters.AddWithValue("@villefac", pro.VilleFacturation);
            requeteClient.Parameters.AddWithValue("@idCommercial", pro.idCommercial);
            requeteClient.ExecuteNonQuery();
            connect.Close();
        }

        /// <summary>
        /// Fonction de création d'une nouvelle fiche professionnel
        /// </summary>
        /// <param name="pro">Contient les informations à envoyer</param>
        public void InsertPro(Professionnel pro)
        {
            connect.Open();
            SqlCommand requeteClient = new SqlCommand("INSERT INTO Client (nom_client, siret_client, domaine_client, type_client, adresse_client, complement_client, code_postal_ville, ville_client, telephone_client, portable_client, mail_client, coefficient_client, adresse_livraison_client, complement_livraison_client, code_postal_livraison_client, ville_livraison, adresse_facturation, complement_facturation, code_postal_facturation, ville_facturation, code_commercial_client, actif_client) VALUES (@nom, @siret, @domaine, @type, @adresse, @complement, @codepostal, @ville, @telephone, @portable, @mail, @coefficient, @adresseliv, @complementliv, @codepostalliv, @villeliv, @adressefac, @complementfac, @codepostalfac, @villefac, @idCommercial, 1)", connect);
            requeteClient.Parameters.AddWithValue("@nom", pro.Nom);
            requeteClient.Parameters.AddWithValue("@siret", pro.Siret);
            requeteClient.Parameters.AddWithValue("@domaine", pro.Domaine);
            requeteClient.Parameters.AddWithValue("@type", pro.Type);
            requeteClient.Parameters.AddWithValue("@adresse", pro.Adresse);
            requeteClient.Parameters.AddWithValue("@complement", pro.Complement);
            requeteClient.Parameters.AddWithValue("@codepostal", pro.CodePostal);
            requeteClient.Parameters.AddWithValue("@ville", pro.Ville);
            requeteClient.Parameters.AddWithValue("@telephone", pro.Telephone);
            requeteClient.Parameters.AddWithValue("@portable", pro.Portable);
            requeteClient.Parameters.AddWithValue("@mail", pro.Mail);
            requeteClient.Parameters.AddWithValue("@coefficient", pro.Coefficient);
            requeteClient.Parameters.AddWithValue("@id", pro.Id);
            requeteClient.Parameters.AddWithValue("@adresseliv", pro.AdresseLivraison);
            requeteClient.Parameters.AddWithValue("@complementliv", pro.ComplementLivraison);
            requeteClient.Parameters.AddWithValue("@codepostalliv", pro.CodePostalLivraison);
            requeteClient.Parameters.AddWithValue("@villeliv", pro.VilleLivraison);
            requeteClient.Parameters.AddWithValue("@adressefac", pro.AdresseFacturation);
            requeteClient.Parameters.AddWithValue("@complementfac", pro.ComplementFacturation);
            requeteClient.Parameters.AddWithValue("@codepostalfac", pro.CodePostalFacturation);
            requeteClient.Parameters.AddWithValue("@villefac", pro.VilleFacturation);
            requeteClient.Parameters.AddWithValue("@idCommercial", pro.idCommercial);
            connect.Close();
        }

        /// <summary>
        /// Fonction de recherche d'information sur un particulier
        /// </summary>
        /// <param name="id">Valeur de l'identifiant client</param>
        /// <returns>Retourne un resultat de type Particulier</returns>
        public Particulier findPar(int id)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("SELECT * FROM Client WHERE code_client =" + id, connect);
            SqlDataReader lecture = requete.ExecuteReader();
            Particulier cli = new Particulier();
            if (lecture.Read())
            {
                cli.Id = (int)lecture["code_client"];
                cli.Nom = lecture["nom_client"].ToString();
                cli.Prenom = lecture["prenom_client"].ToString();
                cli.Type = Convert.ToBoolean(lecture["type_client"]);
                cli.Adresse = lecture["adresse_client"].ToString();
                cli.Complement = lecture["complement_client"].ToString();
                cli.CodePostal = lecture["code_postal_client"].ToString();
                cli.Ville = lecture["ville_client"].ToString();
                cli.Telephone = lecture["telephone_client"].ToString();
                cli.Portable = lecture["portable_client"].ToString();
                cli.Mail = lecture["mail_client"].ToString();
                cli.Coefficient = Convert.ToDecimal(lecture["coefficient_client"]);
                cli.AdresseLivraison = lecture["adresse_livraison_client"].ToString();
                cli.ComplementLivraison = lecture["complement_livraison_client"].ToString();
                cli.CodePostalLivraison = lecture["code_postal_livraison_client"].ToString();
                cli.VilleLivraison = lecture["ville_livraison"].ToString();
                cli.AdresseFacturation = lecture["adresse_facturation"].ToString();
                cli.ComplementFacturation = lecture["complement_facturation"].ToString();
                cli.CodePostalFacturation = lecture["code_postal_facturation"].ToString();
                cli.VilleFacturation = lecture["ville_facturation"].ToString();
                cli.Actif = Convert.ToBoolean(lecture["actif_client"]);
                cli.idCommercial = (int)lecture["code_commercial_client"];
            }
                connect.Close();
            return cli;
        }

        /// <summary>
        /// Fonction de mise à jour d'une fiche client Particulier
        /// </summary>
        /// <param name="part">Contient les nouvelles informations à envoyer</param>
        public void UpdateParticulier(Particulier part)
        {
            connect.Open();
            SqlCommand requeteClient = new SqlCommand("UPDATE Client SET code_commercial_client=@idCommercial, nom_client=@nom, prenom_client=@prenom, type_client=@type, adresse_client=@adresse, complement_client=@complement, code_postal_client=@codepostal, ville_client=@ville, telephone_client=@telephone, portable_client=@portable, mail_client=@mail, coefficient_client=@coefficient, adresse_livraison_client=@adresseliv, complement_livraison_client=@complementliv, code_postal_livraison_client=@codepostalliv, ville_livraison=@villeliv, adresse_facturation=@adressefac, complement_facturation=@complementfac, code_postal_facturation=@codepostalfac, ville_facturation=@villefac WHERE code_client=@id", connect);
            requeteClient.Parameters.AddWithValue("@nom", part.Nom);
            requeteClient.Parameters.AddWithValue("prenom", part.Prenom);
            requeteClient.Parameters.AddWithValue("@type", part.Type);
            requeteClient.Parameters.AddWithValue("@adresse", part.Adresse);
            requeteClient.Parameters.AddWithValue("@complement", part.Complement);
            requeteClient.Parameters.AddWithValue("@codepostal", part.CodePostal);
            requeteClient.Parameters.AddWithValue("@ville", part.Ville);
            requeteClient.Parameters.AddWithValue("@telephone", part.Telephone);
            requeteClient.Parameters.AddWithValue("@portable", part.Portable);
            requeteClient.Parameters.AddWithValue("@mail", part.Mail);
            requeteClient.Parameters.AddWithValue("@coefficient", part.Coefficient);
            requeteClient.Parameters.AddWithValue("@adresseliv", part.AdresseLivraison);
            requeteClient.Parameters.AddWithValue("@complementliv", part.ComplementLivraison);
            requeteClient.Parameters.AddWithValue("@codepostalliv", part.CodePostalLivraison);
            requeteClient.Parameters.AddWithValue("@villeliv", part.VilleLivraison);
            requeteClient.Parameters.AddWithValue("@adressefac", part.AdresseFacturation);
            requeteClient.Parameters.AddWithValue("@complementfac", part.ComplementFacturation);
            requeteClient.Parameters.AddWithValue("@codepostalfac", part.CodePostalFacturation);
            requeteClient.Parameters.AddWithValue("@villefac", part.VilleFacturation);
            requeteClient.Parameters.AddWithValue("@id", part.Id);
            requeteClient.Parameters.AddWithValue("@idCommercial", part.idCommercial);
            requeteClient.ExecuteNonQuery();
            connect.Close();
        }     
          
        /// <summary>
        /// Fonction de création d'une nouvelle fiche client Particulier
        /// </summary>
        /// <param name="part">Contient les informations à envoyer</param>
        public void InsertParticulier (Particulier part)
        {
            connect.Open();
            SqlCommand requeteClient = new SqlCommand("INSERT INTO Client (nom_client, prenom_client, type_client, adresse_client, complement_client, code_postal_client, ville_client, telephone_client, portable_client, mail_client, coefficient_client, adresse_livraison_client, complement_livraison_client, code_postal_livraison_client, ville_livraison, adresse_facturation, complement_facturation, code_postal_facturation, ville_facturation, code_commercial_client, actif_client) VALUES (@nom, @prenom, @type, @adresse, @complement, @codepostal, @ville, @telephone, @portable, @mail, @coefficient, @adresseliv, @complementliv, @codepostalliv, @villeliv, @adressefac, @complementfac, @codepostalfac, @villefac, @idCommercial, 1)", connect);
            requeteClient.Parameters.AddWithValue("@nom", part.Nom);
            requeteClient.Parameters.AddWithValue("@prenom", part.Prenom);
            requeteClient.Parameters.AddWithValue("@type", part.Type);
            requeteClient.Parameters.AddWithValue("@adresse", part.Adresse);
            requeteClient.Parameters.AddWithValue("@complement", part.Complement);
            requeteClient.Parameters.AddWithValue("@codepostal", part.CodePostal);
            requeteClient.Parameters.AddWithValue("@ville", part.Ville);
            requeteClient.Parameters.AddWithValue("@telephone", part.Telephone);
            requeteClient.Parameters.AddWithValue("@portable", part.Portable);
            requeteClient.Parameters.AddWithValue("@mail", part.Mail);
            requeteClient.Parameters.AddWithValue("@coefficient", part.Coefficient);
            requeteClient.Parameters.AddWithValue("@adresseliv", part.AdresseLivraison);
            requeteClient.Parameters.AddWithValue("@complementliv", part.ComplementLivraison);
            requeteClient.Parameters.AddWithValue("@codepostalliv", part.CodePostalLivraison);
            requeteClient.Parameters.AddWithValue("@villeliv", part.VilleLivraison);
            requeteClient.Parameters.AddWithValue("@adressefac", part.AdresseFacturation);
            requeteClient.Parameters.AddWithValue("@complementfac", part.ComplementFacturation);
            requeteClient.Parameters.AddWithValue("@codepostalfac", part.CodePostalFacturation);
            requeteClient.Parameters.AddWithValue("@villefac", part.VilleFacturation);
            requeteClient.Parameters.AddWithValue("@idCommercial", part.idCommercial);
            requeteClient.ExecuteNonQuery();
            connect.Close();
        }

        /// <summary>
        /// Fonction de mise en veille d'une fiche client
        /// </summary>
        /// <param name="id">Valeur de l'identifiant client</param>
        public void Delete(int id)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("UPDATE Client SET actif_client=0 WHERE code_client="+id, connect);
            requete.ExecuteNonQuery();            
            connect.Close();
        }

        /// <summary>
        /// Fonction de remise en service d'une fiche client
        /// </summary>
        /// <param name="id">Identifiant du client</param>
        public void Activate(int id)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("UPDATE Client SET actif_client=true WHERE code_client=" + id, connect);
            requete.ExecuteNonQuery();
            connect.Close();
        }
        
    }
}
