﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nucleo.CrazyTruck
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CrazyTruckEntitiesCn : DbContext
    {
        public CrazyTruckEntitiesCn()
            : base("name=CrazyTruckEntitiesCn")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carga> Carga { get; set; }
        public virtual DbSet<Escala> Escala { get; set; }
        public virtual DbSet<Flete> Flete { get; set; }
        public virtual DbSet<Gandola> Gandola { get; set; }
        public virtual DbSet<Operador> Operador { get; set; }
        public virtual DbSet<Trailer> Trailer { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
