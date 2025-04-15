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
        
        private IPedidoRepository _pedidoRepository;
        

       //public PedidoController(PedidoRepository pedidoRepository)
       // {
            
         //   _pedidoRepository = pedidoRepository;
       // }

        //// GET
        //[HttpGet]
        //public IActionResult ListarProdutos()
        //{
        //    return Ok(_pedidoRepository.ListarTodos());
        //}
    }
}
