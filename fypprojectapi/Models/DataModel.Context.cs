﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fypprojectapi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RENT_A_DRESSEntities : DbContext
    {
        public RENT_A_DRESSEntities()
            : base("name=RENT_A_DRESSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DRESSIMAGE> DRESSIMAGEs { get; set; }
        public DbSet<DRESSINFO> DRESSINFOes { get; set; }
        public DbSet<OWNERFAVORITE> OWNERFAVORITEs { get; set; }
        public DbSet<RENT> RENTs { get; set; }
        public DbSet<USERINFO> USERINFOes { get; set; }
        public DbSet<WHISHLIST> WHISHLISTs { get; set; }
    }
}
