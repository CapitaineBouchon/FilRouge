//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Classes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Commande = new HashSet<Commande>();
            this.Commercial = new HashSet<Commercial>();
        }
    
        public int code_client { get; set; }
        public string nom_client { get; set; }
        public string prenom_client { get; set; }
        public Nullable<bool> type_client { get; set; }
        public string domaine_client { get; set; }
        public string adresse_client { get; set; }
        public string code_postal_client { get; set; }
        public string ville_client { get; set; }
        public string telephone_client { get; set; }
        public string portable_client { get; set; }
        public string mail_client { get; set; }
        public Nullable<double> coefficient_client { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commande> Commande { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commercial> Commercial { get; set; }
    }
}
