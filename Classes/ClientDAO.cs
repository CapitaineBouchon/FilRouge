using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes
{
    class ClientDAO
    {
        SqlConnection connect;
        public ClientDAO(string chaine)
        {
            connect = new SqlConnection(chaine);
        }

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
                maliste.Add(cli);
            }
            lecture.Close();
            connect.Close();
            return maliste;
        }

        public Professionnel findPro(int id)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("SELECT * FROM Client JOIN AdresseDeFacturation ON Client.code_client = AdresseDeFacturation.code_client_facturation JOIN AdresseDeLivraison ON Client.code_client = AdresseDeLivraison.code_client_livraison WHERE code_client ="+id , connect);
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
                cli.Coefficient = (int)lecture["coefficient_client"];
                cli.AdresseLivraison = lecture["adresse_livraison"].ToString();
                cli.ComplementLivraison = lecture["complement_livraison"].ToString();
                cli.CodePostalLivraison = lecture["code_postal_livraison"].ToString();
                cli.VilleLivraison = lecture["ville_livraison"].ToString();
                cli.AdresseFacturation = lecture["adresse_facturation"].ToString();
                cli.ComplementFacturation = lecture["complement_facturation"].ToString();
                cli.CodePostalFacturation = lecture["code_postal_facturation"].ToString();
                cli.VilleFacturation = lecture["ville_facturation"].ToString();
            }
            connect.Close();
            return cli;
        }        
        public void UpdatePro(Professionnel pro)
        {
            connect.Open();
            SqlCommand requeteClient = new SqlCommand("UPDATE FROM Client (nom_client, siret_client, domaine_client, type_client, adresse_client, complement_client, code_postal_ville, ville_client, telephone_client, portable_client, mail_client, coefficient_client) VALUES (@nom, @siret, @domaine, @type, @adresse, @complement, @codepostal, @ville, @telephone, @portable, @mail, @coefficient) WHERE code_client = @id", connect);
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
            requeteClient.ExecuteNonQuery();

            SqlCommand requeteLivraison = new SqlCommand("UPDATE FROM AdresseDeLivraison (adresse_livraison, complement_livraison, code_postal_livraison, ville_livraison) VALUES (@adresse, @complement, @copdepostal, @ville) WHERE code_client_livraison = @id", connect);
            requeteLivraison.Parameters.AddWithValue("@adresse", pro.AdresseLivraison);
            requeteLivraison.Parameters.AddWithValue("@complement", pro.ComplementLivraison);
            requeteLivraison.Parameters.AddWithValue("@codepostal", pro.CodePostalLivraison);
            requeteLivraison.Parameters.AddWithValue("@ville", pro.VilleLivraison);
            requeteLivraison.ExecuteNonQuery();

            SqlCommand requeteFacturation = new SqlCommand("UPDATE FROM AdresseDefacturation (adresse_livraison, complement_livraison, code_postal_livraison, ville_livraison) VALUES (@adresse, @complement, @copdepostal, @ville) WHERE code_client_livraison = @id", connect);
            requeteFacturation.Parameters.AddWithValue("@adresse", pro.AdresseFacturation);
            requeteFacturation.Parameters.AddWithValue("@complement", pro.ComplementFacturation);
            requeteFacturation.Parameters.AddWithValue("@codepostal", pro.CodePostalFacturation);
            requeteFacturation.Parameters.AddWithValue("@ville", pro.VilleFacturation);
            requeteFacturation.ExecuteNonQuery();

            connect.Close();
        }
        public void InsertPro(Professionnel pro)
        {
            connect.Open();
            SqlCommand requeteClient = new SqlCommand("INSERT INTO Client (nom_client, siret_client, domaine_client, type_client, adresse_client, complement_client, code_postal_ville, ville_client, telephone_client, portable_client, mail_client, coefficient_client) VALUES (@nom, @siret, @domaine, @type, @adresse, @complement, @codepostal, @ville, @telephone, @portable, @mail, @coefficient)", connect);
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

            SqlCommand idmax = new SqlCommand("SELECT max(code_client) FROM Client", connect);
            pro.Id = (int)idmax.ExecuteScalar();

            SqlCommand requeteLivraison = new SqlCommand("INSERT INTO AdresseDeLivraison (adresse_livraison, complement_livraison, code_postal_livraison, ville_livraison, code_client_livraison) VALUES (@adresse, @complement, @copdepostal, @ville, @id", connect);
            requeteLivraison.Parameters.AddWithValue("@adresse", pro.AdresseLivraison);
            requeteLivraison.Parameters.AddWithValue("@complement", pro.ComplementLivraison);
            requeteLivraison.Parameters.AddWithValue("@codepostal", pro.CodePostalLivraison);
            requeteLivraison.Parameters.AddWithValue("@ville", pro.VilleLivraison);
            requeteLivraison.Parameters.AddWithValue("@id", pro.Id);
            requeteLivraison.ExecuteNonQuery();

            SqlCommand requeteFacturation = new SqlCommand("INSERT INTO AdresseDefacturation (adresse_livraison, complement_livraison, code_postal_livraison, ville_livraison, code_client_facturation) VALUES (@adresse, @complement, @copdepostal, @ville, @id", connect);
            requeteFacturation.Parameters.AddWithValue("@adresse", pro.AdresseFacturation);
            requeteFacturation.Parameters.AddWithValue("@complement", pro.ComplementFacturation);
            requeteFacturation.Parameters.AddWithValue("@codepostal", pro.CodePostalFacturation);
            requeteFacturation.Parameters.AddWithValue("@ville", pro.VilleFacturation);
            requeteFacturation.Parameters.AddWithValue("@id", pro.Id);
            requeteFacturation.ExecuteNonQuery();

            connect.Close();
        }

        public Particulier findPar(int id)
        {
            connect.Open();
            SqlCommand requete = new SqlCommand("SELECT * FROM Client JOIN AdresseDeFacturation ON Client.code_client = AdresseDeFacturation.code_client_facturation JOIN AdresseDeLivraison ON Client.code_client = AdresseDeLivraison.code_client_livraison WHERE code_client =" + id, connect);
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
                cli.Coefficient = (int)lecture["coefficient_client"];
                cli.AdresseLivraison = lecture["adresse_livraison"].ToString();
                cli.ComplementLivraison = lecture["complement_livraison"].ToString();
                cli.CodePostalLivraison = lecture["code_postal_livraison"].ToString();
                cli.VilleLivraison = lecture["ville_livraison"].ToString();
                cli.AdresseFacturation = lecture["adresse_facturation"].ToString();
                cli.ComplementFacturation = lecture["complement_facturation"].ToString();
                cli.CodePostalFacturation = lecture["code_postal_facturation"].ToString();
                cli.VilleFacturation = lecture["ville_facturation"].ToString();
            }             
            connect.Close();
            return cli;
        }
        public void UpdateParticulier(Particulier part)
        {
            connect.Open();
            SqlCommand requeteClient = new SqlCommand("UPDATE Client SET nom_client=@nom, prenom_client=@prenom, type_client=@type, adresse_client=@adresse, complement_client=@complement, code_postal_client=@codepostal, ville_client=@ville, telephone_client=@telephone, portable_client=@portable, mail_client=@mail, coefficient_client=@coefficient", connect);
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
            requeteClient.ExecuteNonQuery();

            SqlCommand requeteLivraison = new SqlCommand("UPDATE AdresseDeLivraison SET adresse_livraison=@adresse, complement_livraison=@complement, code_postal_livraison=@codepostal, ville_livraison=@ville", connect);
            requeteLivraison.Parameters.AddWithValue("@adresse", part.AdresseLivraison);
            requeteLivraison.Parameters.AddWithValue("@complement", part.ComplementLivraison);
            requeteLivraison.Parameters.AddWithValue("@codepostal", part.CodePostalLivraison);
            requeteLivraison.Parameters.AddWithValue("@ville", part.VilleLivraison);
            requeteLivraison.ExecuteNonQuery();

            SqlCommand requeteFacturation = new SqlCommand("UPDATE AdresseDeFacturation SET adresse_facturation=@adresse, complement_facturation=@complement, code_postal_facturation=@codepostal, ville_facturation=@ville", connect);
            requeteFacturation.Parameters.AddWithValue("@adresse", part.AdresseFacturation);
            requeteFacturation.Parameters.AddWithValue("@complement", part.ComplementFacturation);
            requeteFacturation.Parameters.AddWithValue("@codepostal", part.CodePostalFacturation);
            requeteFacturation.Parameters.AddWithValue("@ville", part.VilleFacturation);
            requeteLivraison.ExecuteNonQuery();
            connect.Close();
        }       
        public void InsertParticulier (Particulier part)
        {
            connect.Open();
            SqlCommand requeteClient = new SqlCommand("INSERT INTO Client (nom_client, prenom_client, type_client, adresse_client, complement_client, code_postal_ville, ville_client, telephone_client, portable_client, mail_client, coefficient_client) VALUES (@nom, @prenom, @type, @adresse, @complement, @codepostal, @ville, @telephone, @portable, @mail, @coefficient)", connect);
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
            requeteClient.ExecuteNonQuery();

            SqlCommand idmax = new SqlCommand("SELECT max(code_client) FROM Client", connect);
            part.Id = (int)idmax.ExecuteScalar();

            SqlCommand requeteLivraison = new SqlCommand("INSERT INTO AdresseDeLivraison (adresse_livraison, complement_livraison, code_postal_livraison, ville_livraison, code_client_livraison) VALUES (@adresse, @complement, @copdepostal, @ville, @id)", connect);
            requeteLivraison.Parameters.AddWithValue("@adresse", part.AdresseLivraison);
            requeteLivraison.Parameters.AddWithValue("@complement", part.ComplementLivraison);
            requeteLivraison.Parameters.AddWithValue("@codepostal", part.CodePostalLivraison);
            requeteLivraison.Parameters.AddWithValue("@ville", part.VilleLivraison);
            requeteLivraison.Parameters.AddWithValue("@id", part.Id);
            requeteLivraison.ExecuteNonQuery();

            SqlCommand requeteFacturation = new SqlCommand("INSERT INTO AdresseDefacturation (adresse_livraison, complement_livraison, code_postal_livraison, ville_livraison, code_client_facturation) VALUES (@adresse, @complement, @copdepostal, @ville, @id)", connect);
            requeteFacturation.Parameters.AddWithValue("@adresse", part.AdresseFacturation);
            requeteFacturation.Parameters.AddWithValue("@complement", part.ComplementFacturation);
            requeteFacturation.Parameters.AddWithValue("@codepostal", part.CodePostalFacturation);
            requeteFacturation.Parameters.AddWithValue("@ville", part.VilleFacturation);
            requeteFacturation.Parameters.AddWithValue("@id", part.Id);
            requeteFacturation.ExecuteNonQuery();

            connect.Close();
        }

        public void Delete(int id)
        {
            connect.Open();

            SqlCommand requeteClient = new SqlCommand("DELETE FROM Client WHERE code_client = " + id, connect);
            requeteClient.ExecuteNonQuery();

            SqlCommand requeteLivraison = new SqlCommand("DELETE FROM AdresseDeLivraison WHERE code_client_livraison = " + id, connect);
            requeteLivraison.ExecuteNonQuery();

            SqlCommand requeteFacturation = new SqlCommand("DELETE FROM AdresseDeFacturation WHERE code_client_facturation = " + id, connect);
            requeteFacturation.ExecuteNonQuery();

            connect.Close();
        }


    }
}
