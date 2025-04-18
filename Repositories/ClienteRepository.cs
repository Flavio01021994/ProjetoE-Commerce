using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;

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
        public void Atualizar(int id, Cliente cliente)
        {
            Cliente cliente1 = _context.Clientes.Find(id);

            cliente1.IdCliente = cliente1.IdCliente;
            cliente1.NomeCompleto = cliente1.NomeCompleto;
            cliente1.Email = cliente1.Email;
            cliente1.Telefone = cliente1.Telefone;
            cliente1.Endereco = cliente1.Endereco;
            cliente1.DatadeCadastro = cliente1.DatadeCadastro;

        }

        public Cliente BuscarPorEmailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(c=> c.IdCliente == id);
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Cliente cliente = _context.Clientes.Find(id);

            if (cliente == null)
            {
                throw new Exception();
            }

            _context.Clientes.Remove(cliente);
        }

        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }

        
    }
}
