using ECommerceAPI.Models;

namespace ECommerceAPI.Interfaces
{
    public interface IItemPedidoRepository
    {
        List<Itempedido> ListarTodos();
        //Recebe um identificador, e retorna o produto correspondente
        Itempedido BuscarPorId(int id);

        // C - Create (cadastro)
        void Cadastrar(Itempedido itemPedido);

        // U - Update (Atualização)
        // Recebe um identificador para encontrar o Produto, e recebe o Produto Novo para subistituir o Antigo
        void Atualizar(int id, Itempedido itemPedido);

        // D - Delete (Deleção)
        // Recebo o identificador de quem quero excluir
        void Deletar(int id);
    }
}
