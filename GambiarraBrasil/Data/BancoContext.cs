using GambiarraBrasil.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography.X509Certificates;

namespace GambiarraBrasil.Data {
    public class BancoContext : DbContext {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) {
        }
        public DbSet<Artigo> Artigos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
