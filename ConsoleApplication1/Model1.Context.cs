﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Fil_rougeEntities : DbContext
    {
        public Fil_rougeEntities()
            : base("name=Fil_rougeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdresseDeFacturation> AdresseDeFacturation { get; set; }
        public virtual DbSet<AdresseDeLivraison> AdresseDeLivraison { get; set; }
        public virtual DbSet<BonLivraison> BonLivraison { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Commercial> Commercial { get; set; }
        public virtual DbSet<compose> compose { get; set; }
        public virtual DbSet<est_livre> est_livre { get; set; }
        public virtual DbSet<Fournisseur> Fournisseur { get; set; }
        public virtual DbSet<Produit> Produit { get; set; }
        public virtual DbSet<regroupe> regroupe { get; set; }
        public virtual DbSet<Rubrique> Rubrique { get; set; }
    }
}