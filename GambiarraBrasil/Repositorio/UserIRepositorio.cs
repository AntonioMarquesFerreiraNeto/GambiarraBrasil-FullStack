using GambiarraBrasil.Models;

namespace GambiarraBrasil.Repositorio {
    public interface UserIRepositorio {
        public Usuario CreateUser(Usuario usuario);
        public Usuario ValidarCredenciais(Autenticar usuario);
    }
}
