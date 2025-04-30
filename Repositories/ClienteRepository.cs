using ECommerceAPI.Context;
using ECommerceAPI.DTO;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;
using ECommerceAPI.Services;
using ECommerceAPI.ViewModels;
using Microsoft.AspNetCore.Http.Connections;

namespace ECommerceAPI.Repositories
{
    // 1 herdar da interface
    // 2 implementar a interface
    // 3 injetar o contexto
    public class ClienteRepository : IClienteRepository
    {
        private readonly EcommerceContext _context;
        

        public ClienteRepository(EcommerceContext context)
        { 
            _context = context;
        }
        public void Atualizar(int id, Cliente clienteNovo)
        {
            // acho o cliente que desejo 
            var clienteEncontrado = _context.Clientes.FirstOrDefault(c => c.IdCliente == id);


            if (clienteEncontrado == null) 
            { 
                throw new AbandonedMutexException("Cliente não encontrado.");
            }

            clienteEncontrado.NomeCompleto = clienteNovo.NomeCompleto;
            clienteEncontrado.Email = clienteNovo.Email;
            clienteEncontrado.Telefone = clienteNovo.Telefone;
            clienteEncontrado.Endereco = clienteNovo.Endereco;
            clienteEncontrado.Senha = clienteNovo.Senha;
            clienteEncontrado.DatadeCadastro = clienteNovo.DatadeCadastro;

            _context.SaveChanges();

        }

        public List<Cliente> BuscarClientePorNome(string nome)
        {
            // where - tras todos que atendem uma condição
            var ListaClientes = _context.Clientes.Where(c => c.NomeCompleto == nome).ToList();

            return ListaClientes;
        }

        /// <summary>
        /// Acessa o banco de dados e encontra o Cliente com email e senha fornecidos
        /// </summary>
        /// <returns>Um cliente ou nulo</returns>
        public Cliente? BuscarPorEmailSenha(string email, string senha)
        {
            // Encontrar o cliente que possui o email e senha fornecidos
            // procuro pelo email
            var clienteEncontrado = _context.Clientes.FirstOrDefault(c => c.Email == email);

            // caso nao encontre, retorno nulo
            if (clienteEncontrado == null)
                return null;


            var passwordService = new PasswordService();

            // verifiar se a senha do usuario gera o mesmo Hash
            var resultado = passwordService.VerificarSenha(clienteEncontrado, senha);

            if(resultado == true) return clienteEncontrado;

            return null;
        }

        public Cliente BuscarPorId(int id)
        {
            // qualquer metodo que vai me trazer apenas 1 cliente
            // Usar First or Default
            return _context.Clientes.FirstOrDefault(c => c.IdCliente == id);
        }

        public void Cadastrar(CadastrarClienteDTO cliente)
        {
            var passwordService = new PasswordService();

            Cliente cadastrarCliente = new Cliente
            {
                NomeCompleto = cliente.NomeCompleto,
                Email = cliente.Email,
                Telefone = cliente.Telefone,
                Endereco = cliente.Endereco,
                Senha = cliente.Senha
            };

            cliente.Senha = passwordService.HashPassword(cadastrarCliente);

            _context.Clientes.Add(cadastrarCliente);
            _context.SaveChanges();
        }

        public void Deletar(int id)
            // find - pesquisa somente pela chave primaria (ID)
        {
            var clienteEncontrado = _context.Clientes.Find(id);
            // caso eu nao encontre o cliente, lanço um erro 
            if (clienteEncontrado != null) 
            
            {
                throw new ArgumentException("Cliente não encontrado");
            }

            // Removo o cliente
            _context.Clientes.Remove(clienteEncontrado);

            //Salvo a alteração
            _context.SaveChanges();
        }

        public List<ListarClienteViewModel> ListarTodos()
        {
            return _context.Clientes
                // Permite que eu selecione quais tempos eu quero pegar
                .Select(
                    c => new ListarClienteViewModel
                    {
                        IdCliente = c.IdCliente,
                        NomeCompleto = c.NomeCompleto,
                        Email = c.Email,
                        Telefone = c.Telefone,
                        Endereco = c.Endereco,
                    })
                .ToList();
        }


    }
}
