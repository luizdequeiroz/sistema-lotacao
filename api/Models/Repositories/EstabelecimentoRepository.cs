using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Dapper;
using System;
using System.Linq;

namespace api.Models.Repositories
{
    public class EstabelecimentoRepository
    {
        private readonly string insert = @"
                                insert into estabelecimento 
                                    ( Nome
                                    , Capacidade
                                    , EnderecoCompleto
                                    , Latitude
                                    , Longitude
                                    , DataCadastro)
                                values
                                    ( @Nome
                                    , @Capacidade
                                    , @EnderecoCompleto                                
                                    , @Latitude  
                                    , @Longitude 
                                    , @DataCadastro);

                                select LAST_INSERT_ID()";

        private readonly string remove = @"
                                insert into estabelecimento 
                                    ( Nome
                                    , Capacidade
                                    , EnderecoCompleto
                                    , Latitude
                                    , Longitude
                                    , DataCadastro)
                                values
                                    ( @Nome
                                    , @Capacidade
                                    , @EnderecoCompleto                                
                                    , @Latitude  
                                    , @Longitude 
                                    , @DataCadastro);

                                select LAST_INSERT_ID()";

        private readonly string connectionString;

        public EstabelecimentoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Estabelecimento> SelectAll()
        {
            var connection = new MySqlConnection(connectionString);

            connection.Open();
            var result = connection.Query<Estabelecimento>("select * from estabelecimento");
            connection.Close();

            return result.AsList();
        }

        public Estabelecimento Insert(Estabelecimento estabelecimento)
        {
            var connection = new MySqlConnection(connectionString);

            connection.Open();
            var result = connection.Query<int>(insert, estabelecimento);
            connection.Close();

            estabelecimento.Id = result.SingleOrDefault();
            return estabelecimento;
        }

        public Estabelecimento Remove(Estabelecimento estabelecimento)
        {
            var connection = new MySqlConnection(connectionString);

            connection.Open();
            var result = connection.Query<int>(remove, estabelecimento);
            connection.Close();

            estabelecimento.Id = result.SingleOrDefault();
            return estabelecimento;
        }
    }
}