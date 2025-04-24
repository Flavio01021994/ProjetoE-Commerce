﻿namespace ECommerceAPI.DTO
{
    public class CadastrarClienteDTO
    {
        public string NomeCompleto { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Telefone { get; set; }

        public string Endereco { get; set; } = null!;

        public string Senha { get; set; } = null!;

        public DateOnly? DatadeCadastro { get; set; }
    }
}
