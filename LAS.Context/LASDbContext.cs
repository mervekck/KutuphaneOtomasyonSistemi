using LAS.Model.Entities.Concrete;
using LAS.Model.Entities.Concrete.Kitap;
using Microsoft.EntityFrameworkCore;

namespace LAS.Context
{
    public class LasDbContext : DbContext
    {
        public DbSet<Roman> RomanKitaplari { get; set; }
        public DbSet<Bilim> BilimKitaplari { get; set; }
        public DbSet<Tarih> TarihKitaplari { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Kutuphane> Kutuphaneler { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.;database=KutuphaneDB;uid=sa;pwd=123;trustservercertificate=true");
            }
        }
    }
}