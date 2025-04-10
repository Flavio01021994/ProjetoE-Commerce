using ECommerceAPI.Models;

namespace ECommerceAPI.Interfaces
{
    public interface IProdutoRepository
    {
        // R - Read (Leitura) 
        // Retorno
        List<Itempedido> ListarTodos();
        //Recebe um identificador, e retorna o produto correspondente
        Itempedido BuscarPorId(int id);

        // C - Create (cadastro)
        void Cadastrar(Itempedido itempedido);

        // U - Update (Atualização)
        // Recebe um identificador para encontrar o Produto, e recebe o Produto Novo para subistituir o Antigo
        void Atualizar(int id, Itempedido itempedido);

        // D - Delete (Deleção)
        // Recebo o identificador de quem quero excluir
        void Deletar(int id);
    }
}
