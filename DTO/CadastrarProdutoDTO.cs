namespace ECommerceAPI.NovaPasta1
{
    public class CadastrarProdutoDTO
    {
        public string Nome { get; set; } = null!;

        public string? Descricao { get; set; }

        public decimal Preco { get; set; }

        public int EstoqueDisponivel { get; set; }

        public string Categoria { get; set; } = null!;

        public string? Imagem { get; set; }
    }
}
