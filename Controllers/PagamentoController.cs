using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        
        private IPagamentoRepository _pagamentoRepository;

        public PagamentoController(PagamentoRepository pagamentoRepository)
        {
            
            _pagamentoRepository = pagamentoRepository;
        }

        // GET
        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_pagamentoRepository.ListarTodos());
        }
    }
}
