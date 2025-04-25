using ECommerceAPI.DTO;
using ECommerceAPI.Models;

namespace ECommerceAPI.Interfaces
{
    public interface IPagamentoRepository
    {
        // R - Read (Leitura) 
        // Retorno
        List<Pagamento> ListarTodos();
        //Recebe um identificador, e retorna o produto correspondente
        Pagamento BuscarPorId(int id);

        // C - Create (cadastro)
        void Cadastrar(CadastrarPagamentoDTO pagamento);

        // U - Update (Atualização)
        // Recebe um identificador para encontrar o Produto, e recebe o Produto Novo para subistituir o Antigo
        void Atualizar(int id, Pagamento pagamento);

        // D - Delete (Deleção)
        // Recebo o identificador de quem quero excluir
        void Deletar(int id);
    }
}