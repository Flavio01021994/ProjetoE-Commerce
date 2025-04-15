using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPedidoController : ControllerBase
    {
        
        private IItemPedidoRepository _itemPedidoRepository;


        public ItemPedidoController(IItemPedidoRepository itemPedidoRepository)
        {

            _itemPedidoRepository = itemPedidoRepository;
        }

        // GET
        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_itemPedidoRepository.ListarTodos());
        }

        [HttpPost]
        public IActionResult CadastrarItemPedido(Itempedido item)
        {
            _itemPedidoRepository.Cadastrar(item);

            return Created();
        }

    }
}
