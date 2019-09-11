using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        IList<Usuario> SelectAll();
        Usuario Insert(Usuario usuario);
        void Delete(int Id);
        void Update(Usuario usuario);
        Usuario SelectById(int id);
        IList<Usuario> SelectByName(String name);

    }
}
