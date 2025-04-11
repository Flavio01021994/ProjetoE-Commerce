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
            throw new NotImplementedException();
        }

        public Cliente BuscarPorEmailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarTodos()
        {
            throw new NotImplementedException();
        }

        
    }
}
