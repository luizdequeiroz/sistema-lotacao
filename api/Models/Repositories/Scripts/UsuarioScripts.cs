namespace api.Models.Repositories.Scripts
{
    public class UsuarioScripts
    {
        internal static readonly string SELECT_ALL = "select * from usuario";
        internal static readonly string INSERT = @"
                                                insert into usuario 
                                                    ( Nome 
                                                    , Nascimento
                                                    , EnderecoCompleto 
                                                    , Email
                                                    , Senha 
                                                    , Genero 
                                                    , DataCadastro )
                                                values 
                                                    ( @Nome
                                                    , @Nascimento
                                                    , @EnderecoCompleto
                                                    , @Email
                                                    , @Senha
                                                    , @Genero
                                                    , @DataCadastro ); 

                                                select LAST_INSERT_ID()";

        internal static readonly string DELETE = "delete from usuario where Id = @Id";
        internal static readonly string UPDATE = @"update usuario set
                                                      Nome = @Nome 
                                                    , Nascimento = @Nascimento 
                                                    , EnderecoCompleto = @EnderecoCompleto
                                                    , Email = @Email
                                                    , Senha = @Senha
                                                    , Genero = @Genero
                                                    , DataAtualizacao = @DataAtualizacao
                                                    Where Id = @Id";
        internal static readonly string SELECT_BY_ID = "select * from usuario where Id = @Id";
        internal static readonly string SELECT_BY_NAME = "select * from usuario where Nome like @Nome";
    }
}
