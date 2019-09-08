using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstabelecimentoController : ControllerBase
    {
        [HttpGet("{quantidade}/{latitude}/{longitude}")]
        public object List(int quantidade, string latitude, string longitude)
        {
            return "Hello, " + nome + " World!";
        }
    }
}
