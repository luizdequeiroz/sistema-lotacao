using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public String EnderecoCompleto { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public char Genero { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

    }
}
