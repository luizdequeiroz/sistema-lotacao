using api.Models;
using api.Models.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            try
            {
                var usuarioCadastrado = usuarioRepository.Insert(usuario);

                return Ok(usuarioCadastrado);
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
                var usuario = usuarioRepository.SelectById(id);

                if (usuario != null)
                {
                    return Ok(usuario);
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
                var usuario = usuarioRepository.SelectByName(name);

                if (usuario.Count > 0)
                {
                    return Ok(usuario);
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
                var usuario = usuarioRepository.SelectAll();

                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Usuario usuario)
        {
            try
            {
                usuario.Id = id;
                usuario.DataAtualizacao = DateTime.Now;

                usuarioRepository.Update(usuario);

                return Ok(usuario);
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
                usuarioRepository.Delete(id);

                return Ok("Usuário deletado com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
