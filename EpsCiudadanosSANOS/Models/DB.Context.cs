﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpsCiudadanosSANOS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EpsEntities : DbContext
    {
        public EpsEntities()
            : base("name=EpsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<consulta> consulta { get; set; }
        public virtual DbSet<cstate> cstate { get; set; }
        public virtual DbSet<medico> medico { get; set; }
        public virtual DbSet<paciente> paciente { get; set; }
        public virtual DbSet<user> user { get; set; }
    }
}