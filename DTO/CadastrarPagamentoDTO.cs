using ECommerceAPI.Models;

namespace ECommerceAPI.DTO
{
    public class CadastrarPagamentoDTO
    {
        public int IdPedido { get; set; }

        public string FormaPagamento { get; set; } = null!;

        public string Status { get; set; } = null!;

        public DateTime Data { get; set; }

        public virtual Pedido? IdPedidoNavigation { get; set; } = null!;
    }
}
