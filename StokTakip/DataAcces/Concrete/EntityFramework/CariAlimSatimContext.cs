using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete.EntityFramework
{
    public class CariAlimSatimContext : DbContext
    {
        private readonly string _sqlKullanıcıAdı = "root";

        public string SqlKullanıcıAdı { get { return _sqlKullanıcıAdı; } }

        private readonly string _sqlSifre = "qweewq123321";
        public string SqlSifre { get { return _sqlSifre; } }

        private readonly string _dataBaseName = "CariAlimSatim";
        public string DataBaseName { get { return _dataBaseName; } }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = $"Data Source=(localdb)\\MSSQLLocalDB;Database={_dataBaseName};User Id={_sqlKullanıcıAdı};Password={_sqlSifre}";

            optionsBuilder.UseSqlServer(connStr);
            //Data Source=(localdb)\MSSQLLocalDB;Database=CariAlimSatim;Trusted_Connection=true
        }

        public DbSet<Cari> Cari { get; set; }
        public DbSet<CariHareket> CariHareket { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<Kullanıcı> Kullanıcı { get; set; }
        public DbSet<Stok> Stok { get; set; }
        public DbSet<Tahsilat> Tahsilat { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<StokHareket> StokHareket { get; set; }
        public DbSet<UrunDetailsDto> UrunDetails { get; set; }
        public DbSet<TahsilatDetailsDto> TahsilatDetails { get; set; }
       
    }
}
