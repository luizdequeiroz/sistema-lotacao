using System;

namespace api.Models
{
    public class Estabelecimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; }
    }
}
