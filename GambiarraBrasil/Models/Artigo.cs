using GambiarraBrasil.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace GambiarraBrasil.Models {
    public class Artigo {

        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Conteúdo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Universidade { get; set; }
    }
}
