using GambiarraBrasil.Data;
using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public Usuario PopularUsuario(RegistroUser value) {
            Usuario usuario = new Usuario();
            usuario.Name = value.Name.Trim();
            usuario.Email = value.Email.Trim();
            usuario.Phone = value.Phone.Trim();
            usuario.SenhaUser = value.SenhaUser.Trim();
            return usuario;
        }

        public Usuario ValidarCredenciais(Autenticar usuario) {
            try {
                string senhaValidation = Criptografia.GerarHash(usuario.Senha);
                Usuario usuarioDB = _bancoContext.Usuarios.FirstOrDefault(x => x.Email == usuario.Email && x.SenhaUser == senhaValidation);
                if (usuarioDB != null) { return usuarioDB; }
                throw new Exception("E-mail ou senha inválida!");
            }
            catch (Exception error) {
                throw new Exception(error.Message);
            }
        }

        public bool ValidarDuplicataUser(Usuario usuario) {
            List<Usuario> usuarios = _bancoContext.Usuarios.ToList();
            if (usuarios.Any(x => x.Email == usuario.Email ||  x.Phone == usuario.Phone)) {
                return true;
            }
            return false;
        }
    }
}
