using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string NomeCompleto { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Telefone { get; set; }

    public string Endereco { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public DateOnly? DatadeCadastro { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
