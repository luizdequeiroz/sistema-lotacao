using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.Repositories.Scripts
{
    public class EstabelecimentoScripts
    {
        internal static readonly string SELECT_ALL = "select * from estabelecimento";
        internal static readonly string INSERT = @"
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
        internal static readonly string DELETE = "delete from estabelecimento where Id = @Id";
        internal static readonly string UPDATE = @"update estabelecimento set
                                                          Nome = @Nome
                                                        , Capacidade = @Capacidade
                                                        , EnderecoCompleto = @EnderecoCompleto
                                                        , Latitude = @Latitude
                                                        , Longitude = @Longitude
                                                        , DataAtualizacao = @DataAtualizacao
                                                   where Id = @Id";
        internal static readonly string SELECT_BY_ID = "select * from estabelecimento where Id = @Id";
        internal static readonly string SELECT_BY_NAME = "select * from estabelecimento where Nome like @Nome";
    }
}
