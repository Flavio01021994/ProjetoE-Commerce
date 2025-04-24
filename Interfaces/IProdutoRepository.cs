using ECommerceAPI.Models;
using ECommerceAPI.NovaPasta1;

namespace ECommerceAPI.Interfaces
{
    public interface IProdutoRepository
    {
        // R - Read (Leitura) 
        // Retorno
        List<Produto> ListarTodos();
        //Recebe um identificador, e retorna o produto correspondente
        Produto BuscarPorId(int id);

        // C - Create (cadastro)
        void Cadastrar(CadastrarProdutoDTO produto);

        // U - Update (Atualização)
        // Recebe um identificador para encontrar o Produto, e recebe o Produto Novo para subistituir o Antigo
        void Atualizar(int id, Produto produto);

        // D - Delete (Deleção)
        // Recebo o identificador de quem quero excluir
        void Deletar(int id);   
        }
}








