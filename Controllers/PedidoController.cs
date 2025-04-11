using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private IPedidoRepository _pedidoRepository;
        

       public PedidoController(EcommerceContext context)
        {
            _context = context;
            _pedidoRepository = new IPedidoRepository(_context);
        }

        // GET
        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_pedidoRepository.ListarTodos());
        }
    }
}
