using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ECommerceAPI.Models;

public partial class Itempedido
{
    public int IdItemPedido { get; set; }

    public int IdPedido { get; set; }

    public int IdProduto { get; set; }

    public int Quantidade { get; set; }

    [JsonIgnore]
    public virtual Pedido Pedido { get; set; } = null!;

    public virtual Produto Produto { get; set; } = null!;
}
