﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShreeFabricators
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class shreedbEntities : DbContext
    {
        public shreedbEntities()
            : base("name=shreedbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<panelbox> panelboxes { get; set; }
        public virtual DbSet<panelboxbill> panelboxbills { get; set; }
        public virtual DbSet<totalbill> totalbills { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
