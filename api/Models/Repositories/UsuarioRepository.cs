using api.Models.Repositories.Interfaces;
using api.Models.Repositories.Scripts;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace api.Models.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly MySqlConnection connection;

        public UsuarioRepository(MySqlConnection connection)
        {
            this.connection = connection;
        }

        public IList<Usuario> SelectAll()
        {
            var result = connection.Query<Usuario>(UsuarioScripts.SELECT_ALL);
            return result.AsList();
        }

        public Usuario Insert(Usuario usuario)
        {
            var result = connection.Query<int>(UsuarioScripts.INSERT, usuario);

            usuario.Id = result.SingleOrDefault();
            return usuario;
        }

        public void Delete(int id)
        {
            connection.Query(UsuarioScripts.DELETE, new { @Id = id });
        }

        public void Update(Usuario usuario)
        {
            connection.Query(UsuarioScripts.UPDATE, usuario);
        }

        public Usuario SelectById(int id)
        {
            var result = connection.Query<Usuario>(UsuarioScripts.SELECT_BY_ID, new { @Id = id });
            return result.SingleOrDefault();
        }

        public IList<Usuario> SelectByName(string name)
        {
            var result = connection.Query<Usuario>(UsuarioScripts.SELECT_BY_NAME, new { @Nome = $"%{name}%" });
            return result.AsList();
        }
    }
}
