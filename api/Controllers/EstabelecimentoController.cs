using api.Models;
using api.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstabelecimentoController : ControllerBase
    {
        private readonly EstabelecimentoRepository estabelecimentoRepository;

        public EstabelecimentoController()
        {
            this.estabelecimentoRepository = new EstabelecimentoRepository("server=localhost;database=lotacao;user=root;password=i2154");
        }

        [HttpGet]
        public IActionResult ListAll()
        {
            try
            {
                var estabelecimentos = estabelecimentoRepository.SelectAll();

                return Ok(estabelecimentos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Create(Estabelecimento estabelecimento)
        {
            try
            {
                Estabelecimento estabelecimentoCadastrado = estabelecimentoRepository.Insert(estabelecimento);

                return Ok(estabelecimentoCadastrado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Remove(Estabelecimento estabelecimento)
        {
            try
            {
                Estabelecimento estabelecimentoCadastrado = estabelecimentoRepository.Remove(estabelecimento);

                return Ok(estabelecimentoCadastrado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
