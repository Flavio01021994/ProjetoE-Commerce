using ECommerceAPI.Models;

namespace ECommerceAPI.Interfaces
{
    public interface IProdutoRepository
    {
        // R - Read (Leitura) 
        // Retorno
        List<Pedido> ListarTodos();
        //Recebe um identificador, e retorna o produto correspondente
        Pedido BuscarPorId(int id);

        // C - Create (cadastro)
        void Cadastrar(Pedido pedido);

        // U - Update (Atualização)
        // Recebe um identificador para encontrar o Produto, e recebe o Produto Novo para subistituir o Antigo
        void Atualizar(int id, Pedido pedido);

        // D - Delete (Deleção)
        // Recebo o identificador de quem quero excluir
        void Deletar(int id);
    }
}
