﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn1_QuanLyThuVien.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyThuVienEntities : DbContext
    {
        public QuanLyThuVienEntities()
            : base("name=QuanLyThuVienEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account_Admin> Account_Admin { get; set; }
        public virtual DbSet<BaoCaoMuonSach> BaoCaoMuonSaches { get; set; }
        public virtual DbSet<BaoCaoTraSach> BaoCaoTraSaches { get; set; }
        public virtual DbSet<DangKyTheTV> DangKyTheTVs { get; set; }
        public virtual DbSet<DauSach> DauSaches { get; set; }
        public virtual DbSet<DKyMuonSach> DKyMuonSaches { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<Sach_Dang_Muon> Sach_Dang_Muon { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TheThuVien> TheThuViens { get; set; }
        public virtual DbSet<TinhTrang_TheTV> TinhTrang_TheTV { get; set; }
        public virtual DbSet<TinhTrangSach> TinhTrangSaches { get; set; }
    }
}