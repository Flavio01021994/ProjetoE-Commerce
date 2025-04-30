using ECommerceAPI.Context;
using ECommerceAPI.DTO;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;
using ECommerceAPI.NovaPasta1;
using ECommerceAPI.Repositories;
using ECommerceAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        
        private IClienteRepository _clienteRepository;

        // Instanciar o PasswordService

        
        public ClienteController(ClienteRepository clienteRepository)
        {

            _clienteRepository = clienteRepository;
        }

        [HttpPost]
        public IActionResult CadastrarCliente(CadastrarClienteDTO prod)
        {
            // 1 - Coloco o produto no Banco de Dados
            _clienteRepository.Cadastrar(prod);



            // 2 - Retorno o resultado
            // 201 - Created
            return Created();
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

        [HttpGet("/buscar/{nome}")]
        public IActionResult BuscarPorNome(string nome)
        {
            return Ok(_clienteRepository.BuscarClientePorNome(nome));
        }

              
        // /api/cliente/vini@senai.com/senha
        [HttpPost("login")]
        public IActionResult Login(LoginDto login)
        { 
            var cliente = _clienteRepository.BuscarPorEmailSenha(login.Email,login.Senha);

            if (cliente == null)
            {
                return Unauthorized("Email ou Senha invalidos!");
            }
            var tokenService = new TokenService();

            var token = tokenService.GenerateToken(cliente.Email);

            return Ok(token);
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
