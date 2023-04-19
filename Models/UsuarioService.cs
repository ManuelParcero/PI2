using System.Linq;
using System.Collections.Generic;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using System;

namespace SBMfotos.Models
{
    public class UsuarioService
    {
        public void Atualizar(Usuario u)
        {
            using(SBMfotosContext bc = new SBMfotosContext())
            {
                Usuario usuario = bc.Usuario.Find(u.Id);
                usuario.Nome = u.Nome;
                usuario.Nascimento = u.Nascimento;
                usuario.Login = u.Login;
                usuario.Email = u.Email;
                usuario.senha = u.senha;
                usuario.senha = u.sexo;
                usuario.senha = u.Inscrito;

                bc.SaveChanges();
            }
        }

        public ICollection<Usuario> ListarTodos(FiltrosUsuario filtro)
        {
            using(SBMfotosContext bc = new SBMfotosContext())
            {
                return bc.Usuario.Include(u => u.Nome).ToList();
            }
        }

        public Usuario ObterPorId(int id)
        {
            using(SBMfotosContext bc = new SBMfotosContext())
            {
                return bc.Usuario.Find(id);
            }
        }

        public void Inserir(Usuario u)
        {
            using(SBMfotosContext bc = new SBMfotosContext())
            {
                bc.Usuario.Add(u);
                bc.SaveChanges();
            }
        }

        internal Usuario ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}