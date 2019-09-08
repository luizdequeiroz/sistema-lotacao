using api.Models.Repositories.Interfaces;
using api.Models.Repositories.Scripts;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace api.Models.Repositories
{
    public class EstabelecimentoRepository : IEstabelecimentoRepository
    {
        private readonly MySqlConnection connection;

        public EstabelecimentoRepository(MySqlConnection connection)
        {
            this.connection = connection;
        }

        public IList<Estabelecimento> SelectAll()
        {
            var result = connection.Query<Estabelecimento>(EstabelecimentoScripts.SELECT_ALL);
            return result.AsList();
        }

        public Estabelecimento Insert(Estabelecimento estabelecimento)
        {
            var result = connection.Query<int>(EstabelecimentoScripts.INSERT, estabelecimento);

            estabelecimento.Id = result.SingleOrDefault();
            return estabelecimento;
        }

        public void Delete(int id)
        {
            connection.Query(EstabelecimentoScripts.DELETE, new { @Id = id });
        }

        public void Update(Estabelecimento estabelecimento)
        {
            connection.Query(EstabelecimentoScripts.UPDATE, estabelecimento);
        }

        public Estabelecimento SelectById(int id)
        {
            var result = connection.Query<Estabelecimento>(EstabelecimentoScripts.SELECT_BY_ID, new { @Id = id });
            return result.SingleOrDefault();
        }

        public IList<Estabelecimento> SelectByName(string name)
        {
            var result = connection.Query<Estabelecimento>(EstabelecimentoScripts.SELECT_BY_NAME, new { @Nome = $"%{name}%" });
            return result.AsList();
        }
    }
}