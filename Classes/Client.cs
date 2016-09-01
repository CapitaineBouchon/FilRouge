using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Client
    {
        //Table Client
        public int Id { get; set; }
        public string Nom { get; set; }   
        public bool Type { get; set; }
        public string Adresse { get; set; }
        public string Complement { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string Portable { get; set; }
        public string Mail { get; set; }
        public float Coefficient { get; set; }

        //Table AdresseDeLivraison
        public string AdresseLivraison { get; set; }
        public string ComplementLivraison { get; set; }
        public string CodePostalLivraison { get; set; }
        public string VilleLivraison { get; set; }

        //Table AdresseDeFacturation
        public string AdresseFacturation { get; set; }
        public string ComplementFacturation { get; set; }
        public string CodePostalFacturation { get; set; }
        public string VilleFacturation { get; set; }        
    }

    public class Particulier : Client
    {
        public string Prenom { get; set; }

    }

    public class Professionnel : Client
    {
        public string Domaine { get; set; }
        public string Siret { get; set; }
    }
}
