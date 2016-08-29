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
    
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            this.BonLivraison = new HashSet<BonLivraison>();
            this.compose = new HashSet<compose>();
        }
    
        public int numero_commande { get; set; }
        public bool paiement { get; set; }
        public Nullable<int> coefficient_reduction { get; set; }
        public System.DateTime date_commande { get; set; }
        public int numero_facture { get; set; }
        public Nullable<System.DateTime> date_facture { get; set; }
        public Nullable<System.DateTime> date_paiement { get; set; }
        public Nullable<int> code_client { get; set; }
        public Nullable<int> code_facturation { get; set; }
    
        public virtual AdresseDeFacturation AdresseDeFacturation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonLivraison> BonLivraison { get; set; }
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compose> compose { get; set; }
    }
}
