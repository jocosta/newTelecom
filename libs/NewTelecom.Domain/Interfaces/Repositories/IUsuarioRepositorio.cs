using System.Collections.Generic;
using NewTelecom.Domain.Entities;

namespace NewTelecom.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepositorio
    {
        Usuario ObterPorId(string id);
        IEnumerable<Usuario> ObterTodos();
        void DesativarLock(string id);
    }
}
