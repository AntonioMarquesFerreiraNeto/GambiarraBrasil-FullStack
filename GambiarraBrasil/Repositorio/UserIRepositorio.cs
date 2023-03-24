using GambiarraBrasil.Models;

namespace GambiarraBrasil.Repositorio {
    public interface UserIRepositorio {
        public RegistroUser CreateUser(RegistroUser usuario);
        public Usuario ValidarCredenciais(Autenticar usuario);
        public Usuario ListUsuarioPorId(int? id);
    }
}
