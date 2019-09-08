using api.Models;
using api.Models.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstabelecimentoController : ControllerBase
    {
        private readonly IEstabelecimentoRepository estabelecimentoRepository;

        public EstabelecimentoController(IEstabelecimentoRepository estabelecimentoRepository)
        {
            this.estabelecimentoRepository = estabelecimentoRepository;
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

        [HttpGet("id={id}")]
        public IActionResult ReadById(int id)
        {
            try
            {
                var estabelecimento = estabelecimentoRepository.SelectById(id);

                if (estabelecimento != null)
                {
                    return Ok(estabelecimento);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{name}")]
        public IActionResult ReadByName(string name)
        {
            try
            {
                var estabelecimentos = estabelecimentoRepository.SelectByName(name);

                if(estabelecimentos.Count > 0)
                {
                    return Ok(estabelecimentos);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult ReadAll()
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

        [HttpPut("{id}")]
        public IActionResult Update(int id, Estabelecimento estabelecimento)
        {
            try
            {
                estabelecimento.Id = id;
                estabelecimento.DataAtualizacao = DateTime.Now;

                estabelecimentoRepository.Update(estabelecimento);

                return Ok(estabelecimento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                estabelecimentoRepository.Delete(id);

                return Ok("Estabelecimento deletado com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
