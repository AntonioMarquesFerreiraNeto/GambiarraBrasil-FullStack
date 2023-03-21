using GambiarraBrasil.Data;

namespace GambiarraBrasil.Repositorio {
    public class ArtigoRepositorio : ArtigoIRepositorio {
        private readonly BancoContext _bancoContext;
        public ArtigoRepositorio(BancoContext bancoContext) {
            _bancoContext = bancoContext;   
        }
        public void Adicionar() {
        }
    }
}
