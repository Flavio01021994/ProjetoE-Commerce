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
    public class ProdutoController : ControllerBase
    {
        
        private IProdutoRepository _produtoRepository;
        // Injeção de dependencia 
        public ProdutoController(IProdutoRepository produtoRepository)
        {

            _produtoRepository = produtoRepository;
        }

        // GET
        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        // Cadastrar Procuto
        [HttpPost]
        public IActionResult CadastrarProduto(Produto prod)
        {
            // 1 - Coloco o produto no Banco de Dados
            _produtoRepository.Cadastrar(prod);

            

            // 2 - Retorno o resultado
            // 201 - Created
            return Created();
        }

        // Buscar Produto por ID
        // /api/produtos
        // /api/produtos/1
        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        { 
            Produto produto = _produtoRepository.BuscarPorId(id);

            if (produto != null) 
            
            {
                // 404 - Nao encontrado
                return NotFound(); 
            }

            return Ok(produto);
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, Produto prod)
        {
            try
            {
                _produtoRepository.Atualizar(id, prod);

                return Ok(prod);
            }

            catch (Exception ex)
            {
                return NotFound("Produto não encontrado");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _produtoRepository.Deletar(id);
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
