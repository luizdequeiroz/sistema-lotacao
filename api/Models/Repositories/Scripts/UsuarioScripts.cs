using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.Repositories.Scripts
{
    public class UsuarioScripts
    {
        internal static readonly string SELECT_ALL = "select * from usuario";
        internal static readonly string INSERT = @"
                                                insert into usuario 
                                                    (Nome, 
                                                    Nascimento, 
                                                    EnderecoCompleto, 
                                                    Email, 
                                                    Senha, 
                                                    Genero, 
                                                    DataCadastro, 
                                                    DataAtualizacao)
                                                values 
                                                    ( @Nome
                                                    , @Nascimento
                                                    , @EnderecoCompleto
                                                    , @Email
                                                    , @Senha
                                                    , @Genero
                                                    , @DataCadastro
                                                    , DataAtualizacao); 

                                                select LAST_INSERT_ID()";

        internal static readonly string DELETE = "delete from usuario where Id = @Id";
        internal static readonly string UPDATE = @"update usuario set
                                                    Nome = @Nome 
                                                    , Nascimento = @Nascimento 
                                                    , EnderecoCompleto = @EnderecoCompleto
                                                    , Email = @Email
                                                    , Senha = @Senha
                                                    , Genero = @Genero
                                                    , DataCadastro = @DataCadastro
                                                    , DataAtualizacao = @DataAtualizacao
                                                    Where Id = @Id";
        internal static readonly string SELECT_BY_ID = "select * from usuario where Id like @Id";
        internal static readonly string SELECT_BY_NAME = "select * from usuario where Nome like @Nome";

    }
}
