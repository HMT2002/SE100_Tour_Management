﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tour.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QL_TOUR_DU_LICHEntities : DbContext
    {
        public QL_TOUR_DU_LICHEntities()
            : base("name=QL_TOUR_DU_LICHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHIPHI> CHIPHIs { get; set; }
        public virtual DbSet<DIADIEM> DIADIEMs { get; set; }
        public virtual DbSet<DOAN> DOANs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHACHSAN> KHACHSANs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHUONGTIEN> PHUONGTIENs { get; set; }
        public virtual DbSet<tb_DOAN> tb_DOAN { get; set; }
        public virtual DbSet<tb_KHACHSAN> tb_KHACHSAN { get; set; }
        public virtual DbSet<tb_NHIEMVU> tb_NHIEMVU { get; set; }
        public virtual DbSet<tb_PHUONGTIEN> tb_PHUONGTIEN { get; set; }
        public virtual DbSet<tb_PHUTRACH> tb_PHUTRACH { get; set; }
        public virtual DbSet<TINH> TINHs { get; set; }
        public virtual DbSet<TOUR> TOURs { get; set; }
    }
}
