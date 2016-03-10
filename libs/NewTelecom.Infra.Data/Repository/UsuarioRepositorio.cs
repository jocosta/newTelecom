using System;
using System.Collections.Generic;
using System.Linq;
using NewTelecom.Domain.Entities;
using NewTelecom.Domain.Interfaces.Repositories;

namespace NewTelecom.Infra.Data.Repository
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
         private readonly Context.AppContext _db;

         public UsuarioRepositorio()
        {
            _db = new Context.AppContext();
        }

        public Usuario ObterPorId(string id)
        {
            return _db.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return _db.Usuarios.ToList();
        }
        public void DesativarLock(string id)
        {
            _db.Usuarios.Find(id).LockoutEnabled = false;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
