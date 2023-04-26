using GambiarraBrasil.Models;
using Microsoft.AspNetCore.Routing.Template;

namespace GambiarraBrasil.Helpers {
    public interface IEmail {
        bool Enviar(string email, string tema, string conteudo);
        bool EnviarRedefinicaoSenha(Usuario usuario, string urlDefinicao);
    }
}
