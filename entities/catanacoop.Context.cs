﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace catanafinals.entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class catanaswordEntities : DbContext
    {
        public catanaswordEntities()
            : base("name=catanaswordEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientInfo> ClientInfoes { get; set; }
        public virtual DbSet<ClientLoan> ClientLoans { get; set; }
        public virtual DbSet<CLINETINFO> CLINETINFOes { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Transact> Transacts { get; set; }
    }
}
