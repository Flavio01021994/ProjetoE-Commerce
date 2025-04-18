﻿using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public DateOnly DataPedido { get; set; }

    public string Status { get; set; } = null!;

    public decimal? ValorTotal { get; set; }

    public int IdCliente { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual ICollection<Itempedido> Itempedidos { get; set; } = new List<Itempedido>();

    public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}
