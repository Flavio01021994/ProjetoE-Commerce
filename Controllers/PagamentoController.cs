using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;
using ECommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        
        private IPagamentoRepository _pagamentoRepository;

        public PagamentoController(IPagamentoRepository pagamentoRepository)
        {
            
            _pagamentoRepository = pagamentoRepository;
        }

        // GET
        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            Pagamento pagamento = _pagamentoRepository.BuscarPorId(id);

            if (pagamento == null) 
            { 
                return NotFound();
            }

            return Ok(pagamento);

        }
        // GET
        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok(_pagamentoRepository.ListarTodos());
        }


        [HttpPut("{id}")]
        public IActionResult Editar(int id, Pagamento prod) 
        {
            try
            {
                _pagamentoRepository.Atualizar(id, prod);

                return Ok();
            }

            catch (Exception ex)
            {
                return NotFound("Produto não encontrado"); 
                
            }
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            try

            {
                _pagamentoRepository.Deletar(id);
                return NoContent();
            }

            catch (Exception ex) 
            
            {
                return NotFound("Produto não encontrado.");
            }
        }
    }
}
