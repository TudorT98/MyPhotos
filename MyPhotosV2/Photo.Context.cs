﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotosV2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PhotoContainer : DbContext
    {
        public PhotoContainer()
            : base("PhotoContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Photo> PhotoSet { get; set; }
        public virtual DbSet<LandScape> LandScapeSet { get; set; }
        public virtual DbSet<Location> LocationSet { get; set; }
        public virtual DbSet<Event> EventSet { get; set; }
        public virtual DbSet<Person> PersonSet { get; set; }
    }
}
