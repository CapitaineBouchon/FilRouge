//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class est_livre
    {
        public int quantite_livraison { get; set; }
        public System.DateTime date_livraison { get; set; }
        public int code_livraison { get; set; }
        public int code_produit { get; set; }
        public int code_fournisseur { get; set; }
    
        public virtual Produit Produit { get; set; }
        public virtual Fournisseur Fournisseur { get; set; }
    }
}