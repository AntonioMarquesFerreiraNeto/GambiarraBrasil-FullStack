using GambiarraBrasil.Models;

namespace GambiarraBrasil.Repositorio {
    public interface UserIRepositorio {
        public RegistroUser CreateUser(RegistroUser usuario);
        public Usuario UpdateUser(Usuario usuario);
        public MudarSenha UpdateSenha(MudarSenha mudarSenha);
        public Usuario ValidarCredenciais(Autenticar usuario);
        public Usuario ListUsuarioPorId(int? id);
        public Usuario ListUsuarioPorIdNoJoin(int? id);
    }
}
