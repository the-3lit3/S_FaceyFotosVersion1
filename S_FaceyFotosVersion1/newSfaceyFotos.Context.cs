﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S_FaceyFotosVersion1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_sfaceyFotos2Entities3 : DbContext
    {
        public db_sfaceyFotos2Entities3()
            : base("name=db_sfaceyFotos2Entities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_cardType> tb_cardType { get; set; }
        public virtual DbSet<tb_packageType> tb_packageType { get; set; }
        public virtual DbSet<tb_shootTime> tb_shootTime { get; set; }
        public virtual DbSet<tb_bookingInfo> tb_bookingInfo { get; set; }
        public virtual DbSet<tb_userRegistration> tb_userRegistration { get; set; }
    }
}
