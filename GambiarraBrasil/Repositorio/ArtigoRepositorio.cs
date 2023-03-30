using GambiarraBrasil.Data;
using GambiarraBrasil.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace GambiarraBrasil.Repositorio {
    public class ArtigoRepositorio : ArtigoIRepositorio {
        private readonly BancoContext _bancoContext;
        public ArtigoRepositorio(BancoContext bancoContext) {
            _bancoContext = bancoContext;
        }

        public List<Artigo> ListArtigos() {
            return _bancoContext.Artigo.ToList();
        }

        public Artigo ListForIdArtigo(int? id) {
            return _bancoContext.Artigo
                .AsNoTracking()
                .Include(x => x.Usuario).FirstOrDefault(x => x.Id == id);
        }

        public Artigo NovoArtigo(Artigo artigo) {
            try {
                artigo.Trim();
                artigo.Usuario = _bancoContext.Usuario.FirstOrDefault(x => x.Id == artigo.Usuario.Id);
                artigo.DataPublication = DateTime.Now.Date;
                if (ValidarDuplicateTitle(artigo)) throw new Exception("Desculpe, alguns dos dados registrados já foram registrados no sistema!");
                _bancoContext.Artigo.Add(artigo);
                _bancoContext.SaveChanges();
                return artigo;
            }
            catch (Exception error) {
                throw new Exception(error.Message);
            }
        }

        public Artigo EditarArtigo(Artigo artigo) {
            try {
                Artigo artigoDB = _bancoContext.Artigo.FirstOrDefault(x => x.Id == artigo.Id);
                if (artigoDB == null) throw new Exception("Desculpe, artigo não encontrado!");
                if (ValidarDuplicateTitleEdit(artigo, artigoDB)) throw new Exception("Desculpe, alguns dos dados registrados já foram registrados no sistema!");
                artigo.Trim();
                artigoDB.Titulo = artigo.Titulo;
                artigoDB.SubTitulo = artigo.SubTitulo;
                artigoDB.CategoriaArtigo = artigo.CategoriaArtigo;
                artigoDB.Conteudo = artigo.Conteudo;
                artigoDB.Type = artigo.Type;
                artigoDB.Universidade = artigo.Universidade;
                _bancoContext.Artigo.Update(artigoDB);
                _bancoContext.SaveChanges();
                return artigoDB;
            }
            catch (Exception error) {
                throw new Exception(error.Message);
            }
        }


        public Artigo Trim(Artigo artigo) {
            artigo.Titulo = artigo.Titulo.Trim();
            artigo.SubTitulo = artigo.SubTitulo.Trim();
            artigo.Universidade = artigo.Universidade.Trim();
            artigo.Conteudo = artigo.Conteudo.Trim();
            return artigo;
        }
        public bool ValidarDuplicateTitle(Artigo artigo) {
            if (_bancoContext.Artigo.Any(x => x.Titulo == artigo.Titulo)) {
                return true;
            }
            else {
                return false;
            }
        }
        public bool ValidarDuplicateTitleEdit(Artigo artigo, Artigo artigoDB) {
            if (_bancoContext.Artigo.Any(x => x.Titulo == artigo.Titulo && x.Titulo != artigoDB.Titulo)) {
                return true;
            } 
            return false;
        }

        public Artigo Excluir(Artigo artigo) {
            try {
                Artigo artigoDB = _bancoContext.Artigo.FirstOrDefault(x => x.Id == artigo.Id);
                if (artigoDB == null) throw new Exception("Desculpe, artigo não foi encontrado!");
                _bancoContext.Artigo.Remove(artigoDB);
                _bancoContext.SaveChanges();
                return artigoDB;
            }
            catch (Exception error) {
                throw new Exception(error.Message);
            }
        }
    }
}
