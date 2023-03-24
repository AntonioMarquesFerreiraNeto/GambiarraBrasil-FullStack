using GambiarraBrasil.Data;
using GambiarraBrasil.Models;
using System.Collections.Generic;

namespace GambiarraBrasil.Repositorio {
    public interface ArtigoIRepositorio {
        public Artigo NovoArtigo(Artigo artigo);
        public List<Artigo> ListArtigos();
        public Artigo ListForIdArtigo(int? id);
    }
}
