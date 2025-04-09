using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models;

public partial class Produto
{
    public int IdProduto { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public decimal? Preco { get; set; }

    public int? EstoqueDisponivel { get; set; }

    public string? Categoria { get; set; }

    public string? Imagem { get; set; }

    public virtual ICollection<Itempedido> Itempedidos { get; set; } = new List<Itempedido>();
}
