using System.Collections.Generic;

namespace api.Models
{
    public class EstabelecimentoMocks
    {
        public static readonly IList<dynamic> Dados = new List<dynamic>
        {
            new
            {
                Nome = "Caça e Pesca",
                Quantidade = 150,
                Latitude = "1234",
                Longitude = "5678"
            },
            new
            {
                Nome = "Raimundão Rei da Asa",
                Quantidade = 100,
                Latitude = "4321",
                Longitude = "8765"
            },
            new
            {
                Nome = "Porquilo",
                Quantidade = 60,
                Latitude = "1478",
                Longitude = "9632"
            }
        };
    }
}
