using ECommerceAPI.Context;
using ECommerceAPI.DTO;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerceAPI.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly EcommerceContext _context;

        // ctor
        // metodo construtor
        //Quando criar um objeto o que eu preciso ter?
        public PedidoRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Pedido BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(CadastrarPedidoDto pedidoDto)
        {
            // Cadastrar o Pedido
            // crio uma variavel pedido para guardar as informações do pedido
            var pedido = new Pedido
            {
                DataPedido = pedidoDto.DataPedido,
                Status = pedidoDto.Status,
                IdCliente = pedidoDto.IdCliente,    
                ValorTotal = pedidoDto.ValorTotal,
            
            };

            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            // Cadastrar 0s ItensPedido
            // Para cada Produto, eu crio um ItemPedido
            // ["Vinicio", "Fulano"] 
            // [12, 18, 22]

            for (int i = 0; i < pedidoDto.Produtos.Count; i++) 
            {
                // encontro o produto
                var produto = _context.Produtos.Find(pedidoDto.Produtos[i]);

                // TODO: Lançar erro se o produto nao existe
                // crio uma variavel ItemPedido
                var itemPedido = new Itempedido
                {
                    IdPedido = pedido.IdPedido,
                    IdProduto = produto.IdProduto,
                    Quantidade = 0
                };
                // Jogo no banco de dados e salvo
                _context.Itempedidos.Add(itemPedido);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> ListarTodos()
        {
            return _context.Pedidos
                .Include(p => p.Itempedidos)
                .ThenInclude(p => p.Produto)
                .ToList();
                
        }
    }
}
