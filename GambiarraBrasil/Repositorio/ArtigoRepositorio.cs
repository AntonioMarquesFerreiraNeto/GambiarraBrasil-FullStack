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
                if (ValidarDuplicateTitle(artigo.Titulo)) throw new Exception("Este título já foi usado em outro conteúdo!");
                _bancoContext.Artigo.Add(artigo);
                _bancoContext.SaveChanges();
                return artigo;
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
        public bool ValidarDuplicateTitle(string title) {
            if (_bancoContext.Artigo.Any(x => x.Titulo == title)) {
                return true;
            }
            else {
                return false;
            }
        }

        public bool ValidarDuplicateTitleEdit(string title) {
            //Inserir as instruções de validação de duplicatas que estão sendo editadas neste local. 
            return true;
        }
    }
}
