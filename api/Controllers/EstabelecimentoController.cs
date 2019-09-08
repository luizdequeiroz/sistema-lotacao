using api.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstabelecimentoController : ControllerBase
    {
        [HttpGet("{quantidade}/{latitude}/{longitude}")]
        public IActionResult List(int quantidade, string latitude, string longitude)
        {
            try
            {
                var estabelecimentos = EstabelecimentoMocks.Dados;

                dynamic selecinado = null;
                foreach (var estabelecimento in estabelecimentos)
                {
                    if (estabelecimento.Quantidade == quantidade
                        && estabelecimento.Latitude == latitude
                        && estabelecimento.Longitude == longitude)
                    {
                        selecinado = estabelecimento;
                    }
                }

                if (selecinado != null)
                {
                    return Ok(selecinado);
                }
                else
                {
                    return BadRequest("Nenhum estabelecimento encontrado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
