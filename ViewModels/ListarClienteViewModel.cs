using ECommerceAPI.Models;

namespace ECommerceAPI.ViewModels
{
    public class ListarClienteViewModel
    {
        public int IdCliente { get; set; }

        public string NomeCompleto { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Telefone { get; set; }

        public string Endereco { get; set; } = null!;          

        public DateOnly? DatadeCadastro { get; set; }
                
    }
}
