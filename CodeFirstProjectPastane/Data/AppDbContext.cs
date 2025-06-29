using System;
using CodeFirstProjectPastane.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstProjectPastane.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Departman> Departmans { get; set; }
    }
}

