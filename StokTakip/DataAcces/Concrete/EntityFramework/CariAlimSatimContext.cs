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

        public DbSet<Cari> Cariler { get; set; }
        public DbSet<CariHareket> CariHareketler { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<Kullanıcı> Kullanıcılar { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Tahsilat> Tahsilatlar { get; set; }
    }
}
