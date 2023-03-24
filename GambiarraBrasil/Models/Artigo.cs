using GambiarraBrasil.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace GambiarraBrasil.Models {
    public class Artigo {

        public int Id { get; set; }

        public int? UsuarioId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string SubTitulo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public Categoria CategoriaArtigo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public TypeTrabalho Type { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(700, ErrorMessage = "Informe no mínimo 700 caracteres!")]
        public string Conteudo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Universidade { get; set; }

        public DateTime? DataPublication { get; set; }

        public Usuario Usuario { get; set; }

        public void Trim() {
            Titulo = Titulo.Trim();
            SubTitulo = SubTitulo.Trim();
            Universidade = Universidade.Trim();
            Conteudo = Conteudo.Trim();
        }

        public string ReturnTypeTrabalho() {
            if (Type == TypeTrabalho.Resenha) {
                return "Resenha";
            }
            else if (Type == TypeTrabalho.Redacao) {
                return "Redação";
            }
            else if (Type == TypeTrabalho.Monografia) {
                return "Monografia";
            }
            else if (Type == TypeTrabalho.Fichamento) {
                return "Fichamento";
            }
            else if (Type == TypeTrabalho.ArtigoCientífico) {
                return "Artigo científico";
            }
            else if (Type == TypeTrabalho.Relatorio) {
                return "Relatório";
            }
            else if (Type == TypeTrabalho.Resumo) {
                return "Resumo";
            }
            else {
                return "Desculpe, não encontramos!";
            }
        }

        public string ReturnCategoria() {
            if (CategoriaArtigo == Enum.Categoria.BancoDados) {
                return "Banco de dados";
            }
            else if(CategoriaArtigo == Enum.Categoria.EngenhariaSoftware) {
                return "Engenharia de software";
            }
            else if (CategoriaArtigo == Enum.Categoria.EngenhariaRequisitos) {
                return "Engenharia de requisitos";
            }
            else if (CategoriaArtigo == Enum.Categoria.RedesComputadores) {
                return "Redes de computadores";
            }
            else if (CategoriaArtigo == Enum.Categoria.GovernancaTI) {
                return "Governança de TI";
            }
            else if (CategoriaArtigo == Enum.Categoria.DesenvolvimentoWeb) {
                return "Desenvolvimento WEB";
            }
            else if (CategoriaArtigo == Enum.Categoria.DesenvolvimentoDesktop) {
                return "Desenvolvimento Desktop";
            }
            else if (CategoriaArtigo == Enum.Categoria.DesenvolvimentoMobile) {
                return "Desenvolvimento Mobile";
            }
            else if (CategoriaArtigo == Enum.Categoria.ComputacaoMovel) {
                return "Computação móvel";
            }
            else if (CategoriaArtigo == Enum.Categoria.Ecommerce) {
                return "E-commerce";
            }
            else if (CategoriaArtigo == Enum.Categoria.InfraTI) {
                return "Infraestrutura de TI";
            }
            else if (CategoriaArtigo == Enum.Categoria.SegurancaInformacao) {
                return "Segurança da informação";
            }
            else if (CategoriaArtigo == Enum.Categoria.InteligenciaArtificial) {
                return "Inteligência artificial";
            }
            else if (CategoriaArtigo == Enum.Categoria.SuporteTecnico) {
                return "Suporte técnico de TI";
            }
            else {
                return "Não encontramos!";
            }
        }
    }
}
