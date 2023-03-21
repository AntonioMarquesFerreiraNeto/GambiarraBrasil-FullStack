using GambiarraBrasil.Models;

namespace GambiarraBrasil.Helpers {
    public interface ISection {
        void CriarSection(Usuario usuario);
        void EncerrarSection();
        Usuario buscarSectionUser();
    }
}
