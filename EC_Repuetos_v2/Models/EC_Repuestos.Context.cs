﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC_Repuetos_v2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_PROYECTO_WEBEntities : DbContext
    {
        public DB_PROYECTO_WEBEntities()
            : base("name=DB_PROYECTO_WEBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EC_COMPRAS> EC_COMPRAS { get; set; }
        public virtual DbSet<EC_PRODUCTOS> EC_PRODUCTOS { get; set; }
        public virtual DbSet<EC_USUARIOS> EC_USUARIOS { get; set; }
    }
}
