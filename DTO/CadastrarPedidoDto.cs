namespace ECommerceAPI.DTO
{ 
    // recebo os dados do pedido
    // e recebo os produtos comprados
    public class CadastrarPedidoDto
    {
        public DateOnly DataPedido { get; set; }

        public string Status { get; set; } = null!;

        public decimal? ValorTotal { get; set; }

        public int IdCliente { get; set; }

        // produtos comprados
        public List<int> Produtos { get; set; }
    }
}
