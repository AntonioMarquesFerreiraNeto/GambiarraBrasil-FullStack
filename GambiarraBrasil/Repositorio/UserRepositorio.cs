using GambiarraBrasil.Data;
using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Xml.Linq;

namespace GambiarraBrasil.Repositorio {
    public class UserRepositorio : UserIRepositorio {
        private readonly BancoContext _bancoContext;
        public UserRepositorio(BancoContext bancoContext) {
            _bancoContext = bancoContext;
        }

        public RegistroUser CreateUser(RegistroUser registroUser) {
            try {
                Usuario usuario = PopularUsuario(registroUser);
                if (ValidarDuplicataUser(usuario)) throw new Exception("Desculpe, alguns dos registros passados já existem no sistema!");
                usuario.CriptografarSenha();
                _bancoContext.Add(usuario);
                _bancoContext.SaveChanges();
                return registroUser;
            }
            catch (Exception error) {
                throw new Exception(error.Message);
            }
        }

        public Usuario ListUsuarioPorId(int? id) {
            return _bancoContext
                .Usuario
                .AsNoTracking()
                .Include(x => x.Artigos)
                .FirstOrDefault(x => x.Id == id);
        }

        public Usuario ListUsuarioPorIdNoJoin(int? id) {
            return _bancoContext.Usuario.FirstOrDefault(x => x.Id == id);
        }

        public Usuario PopularUsuario(RegistroUser value) {
            Usuario usuario = new Usuario();
            usuario.Name = value.Name.Trim();
            usuario.Email = value.Email.Trim();
            usuario.Phone = value.Phone.Trim();
            usuario.SenhaUser = value.SenhaUser.Trim();
            return usuario;
        }

        public MudarSenha UpdateSenha(MudarSenha mudarSenha) {
            try {
                //Recebendo o objeto senha, buscando o usuário e realizando validações.
                Usuario usuarioDB = _bancoContext.Usuario.FirstOrDefault(x => x.Id == mudarSenha.Id);
                if (usuarioDB == null) throw new Exception("Desculpe, usuário não encontrado!");
                mudarSenha.NovaSenha = Criptografia.GerarHash(mudarSenha.NovaSenha.Trim());
                mudarSenha.SenhaAtual = Criptografia.GerarHash(mudarSenha.SenhaAtual.Trim());
                if (mudarSenha.SenhaAtual != usuarioDB.SenhaUser) throw new Exception("Senha atual não confere!");
                if (mudarSenha.NovaSenha == usuarioDB.SenhaUser) throw new Exception("A nova senha tem que ser diferente que a senha atual!");
                
                //Atualizando a senha do usuário.
                //ATENÇÃO: A nova senha não está sendo criptografada no código abaixo porquê já foi criptografada logo acima.
                usuarioDB.SenhaUser = mudarSenha.NovaSenha;
                _bancoContext.Usuario.Update(usuarioDB);
                _bancoContext.SaveChanges();
                return mudarSenha;
            }
            catch (Exception error) {
                throw new Exception(error.Message);
            }
        }

        public Usuario UpdateUser(Usuario usuario) {
            try {
                Usuario usuarioDB = _bancoContext.Usuario.FirstOrDefault(x => x.Id == usuario.Id);
                if (usuarioDB == null) throw new Exception("Desculpe, usuário não encontrado!");
                if (ValidarDuplicateUserEdit(usuario, usuarioDB)) throw new Exception("Desculpe, usuário já se encontra registrado!");
                usuarioDB.Name = usuario.Name.Trim();
                usuarioDB.Email = usuario.Email.Trim();
                usuarioDB.Phone = usuario.Phone.Trim();
                _bancoContext.Usuario.Update(usuarioDB);
                _bancoContext.SaveChanges();
                return usuarioDB;
            }
            catch (Exception error) {
                throw new Exception(error.Message);
            }
        }

        public Usuario ValidarCredenciais(Autenticar usuario) {
            try {
                string senhaValidation = Criptografia.GerarHash(usuario.Senha);
                Usuario usuarioDB = _bancoContext.Usuario.FirstOrDefault(x => x.Email == usuario.Email && x.SenhaUser == senhaValidation);
                if (usuarioDB != null) { return usuarioDB; }
                throw new Exception("E-mail ou senha inválida!");
            }
            catch (Exception error) {
                throw new Exception(error.Message);
            }
        }

        public bool ValidarDuplicataUser(Usuario usuario) {
            List<Usuario> usuarios = _bancoContext.Usuario.ToList();
            if (usuarios.Any(x => x.Email == usuario.Email || x.Phone == usuario.Phone)) {
                return true;
            }
            return false;
        }

        public bool ValidarDuplicateUserEdit(Usuario usuario, Usuario usuarioDB) {
            List<Usuario> usuarios = _bancoContext.Usuario.ToList();
            if (usuarios.Any(x => (x.Email == usuario.Email && usuarioDB.Email != usuario.Email)
                || (x.Phone == usuario.Phone && usuarioDB.Phone != usuario.Phone))) {
                return true;
            }
            return false;
        }
    }
}
