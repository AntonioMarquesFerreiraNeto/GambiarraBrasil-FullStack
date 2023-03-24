using GambiarraBrasil.Data.Map;
using GambiarraBrasil.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography.X509Certificates;

namespace GambiarraBrasil.Data {
    public class BancoContext : DbContext {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) {
        }
        public DbSet<Artigo> Artigo { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new MapArtigo());
            base.OnModelCreating(modelBuilder);
        }
    }
}
