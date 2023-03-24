using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models.ValidationsModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GambiarraBrasil.Models {
    public class Usuario {

        public int Id { get; set; }

        
        public string Name { get; set; }

      
        public string Email { get; set; }

        
        public string Phone { get; set; }

       
        public string SenhaUser { get; set; }

        public void CriptografarSenha() {
            SenhaUser = Criptografia.GerarHash(SenhaUser);
        }

        public virtual List<Artigo> Artigos { get; set; }
    }
}
