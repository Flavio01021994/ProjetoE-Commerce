using ECommerceAPI.DTO;
using ECommerceAPI.Models;
using ECommerceAPI.ViewModels;

namespace ECommerceAPI.Interfaces
{
    public interface IClienteRepository
    {
        // R - Read (Leitura) 
        // Retorno
        List<ListarClienteViewModel> ListarTodos();
        //Recebe um identificador, e retorna o produto correspondente
        Cliente BuscarPorId(int id);
        Cliente BuscarPorEmailSenha(string email, string senha);

        // C - Create (cadastro)
        void Cadastrar(CadastrarClienteDTO cliente);

        // U - Update (Atualização)
        // Recebe um identificador para encontrar o Produto, e recebe o Produto Novo para subistituir o Antigo
        void Atualizar(int id, Cliente cliente);

        // D - Delete (Deleção)
        // Recebo o identificador de quem quero excluir
        void Deletar(int id);

        List<Cliente> BuscarClientePorNome(string nome);

        
       
    }
}