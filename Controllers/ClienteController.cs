using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
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
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_clienteRepository.ListarTodos());
        }
    }
}
