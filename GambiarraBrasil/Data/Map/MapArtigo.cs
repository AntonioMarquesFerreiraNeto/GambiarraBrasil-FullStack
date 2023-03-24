using GambiarraBrasil.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GambiarraBrasil.Data.Map {
    public class MapArtigo : IEntityTypeConfiguration<Artigo> {
        public void Configure(EntityTypeBuilder<Artigo> builder) {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Usuario);
        }
    }
}
