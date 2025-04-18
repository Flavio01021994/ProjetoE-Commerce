using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;
using ECommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        
        private IClienteRepository _clienteRepository;

        public ClienteController(ClienteRepository clienteRepository)
        {

            _clienteRepository = clienteRepository;
        }

        // GET
        [HttpGet("{id}")]
        public IActionResult ListarporID(int id)
        {
            Cliente cliente = _clienteRepository.BuscarPorId(id);

            if (cliente == null)
            { 
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, Cliente cliet)
        {
            try
            {
                _clienteRepository.Atualizar(id, cliet);

                return Ok(cliet);
            }

            catch (Exception ex)
            {
                return NotFound("Cliente não encontrado");
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _clienteRepository.Deletar(id);
                // 204 - Deu Certo
                return NoContent();
            }
            // Caso de erro
            catch (Exception ex)
            {
                return NotFound("Produto não encontrado.");
            }
        }

    }
}
