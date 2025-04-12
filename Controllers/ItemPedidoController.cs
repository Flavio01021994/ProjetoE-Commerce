using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPedidoController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private IItemPedidoRepository _itemPedidoRepository;


        public ItemPedidoController(EcommerceContext context)
        {
            _context = context;
            //_itemPedidoRepository = new ItemPedidoRe(_context);
        }

        // GET
        //[HttpGet]
        //public IActionResult ListarProdutos()
        //{
        //    return Ok(_context.ListarTodos());
        //}
    }
}
