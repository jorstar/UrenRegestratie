﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UrenRegestratie
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UrenRegCon : DbContext
    {
        public UrenRegCon()
            : base("name=UrenRegCon")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Regestratie> Regestraties { get; set; }
        public DbSet<taak> taaks { get; set; }
        public DbSet<user_taak> user_taak { get; set; }
    }
}
