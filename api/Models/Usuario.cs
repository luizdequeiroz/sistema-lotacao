using System;

namespace api.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string EnderecoCompleto { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public char Genero { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
