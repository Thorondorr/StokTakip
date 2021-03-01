using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete.EntityFramework
{
    public class CariAlimSatimContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=CariAlimSatim;Trusted_Connection=true");
                       
        }

        public DbSet<Cari> Cari { get; set; }
        public DbSet<CariHareket> CariHareket { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<Kullanıcı> Kullanıcı { get; set; }
        public DbSet<Stok> Stok { get; set; }
        public DbSet<Tahsilat> Tahsilat { get; set; }
        public DbSet<Urun> Urun { get; set; }
    }
}
