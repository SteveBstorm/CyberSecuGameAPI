using Microsoft.EntityFrameworkCore;
using Models.Entities_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI.EF
{
    public class DataContext : DbContext
    {
        public DbSet<Jeu> Jeux { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=STEVEBSTORM\MSSQLSERVER01;Initial Catalog=CyberSecuEF_Game;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JeuConfig());
            modelBuilder.ApplyConfiguration(new GenreConfig());
        }
    }
}
