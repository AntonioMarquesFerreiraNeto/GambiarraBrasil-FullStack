using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models.ValidationsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GambiarraBrasil.Models {
    public class Usuario {

        public int Id { get; set; }

        [Required (ErrorMessage = "Campo obrigatório!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidarEmail(ErrorMessage = "E-mail inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Phone { get; set; }

        public string SenhaUser { get; set; }

        public string Token { get; set; }

        public void CriptografarSenha() {
            SenhaUser = Criptografia.GerarHash(SenhaUser);
        }

        public virtual List<Artigo> Artigos { get; set; }

        public void GerarTokken() {
            Random random = new Random();
            int op = random.Next(2);
            int tamanho = (op == 0) ? 30: 35;
            string caixaCaracteres = "!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~€‚ƒ„…†‡ˆ‰Š‹Œ‘’“”•–—˜™š›œŸ¡¢£¤¥¦§¨©ª«¬®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ";
            StringBuilder tokken = new StringBuilder(); 
            for (int c = 0; c < tamanho; c++) {
                int indiceChar = random.Next(0, caixaCaracteres.Length - 1);
                tokken.Append(caixaCaracteres[indiceChar]);
            }
            Token = Criptografia.GerarHash(tokken.ToString());
        }
    }
}
