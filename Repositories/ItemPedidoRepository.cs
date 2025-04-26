using ECommerceAPI.Context;
using ECommerceAPI.DTO;
using ECommerceAPI.Models;
using ECommerceAPI.NovaPasta1;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Repositories
{
    public class ItemPedidoRepository
    {
        private readonly EcommerceContext _context;


        public ItemPedidoRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, Itempedido itemPedido)
        {
            // Encontro o produto que desejo
            Itempedido itempedidoencontrado = _context.Itempedidos.Find(id);

            itempedidoencontrado.IdItemPedido = itemPedido.IdItemPedido;
            itempedidoencontrado.IdPedido = itemPedido.IdPedido;
            itempedidoencontrado.IdProduto = itemPedido.IdPedido;
            itempedidoencontrado.Quantidade = itemPedido.Quantidade;



        _context.SaveChanges();
        }

        public Itempedido BuscarPorId(int id)
        {
            return _context.Itempedidos.FirstOrDefault(ip => ip.IdItemPedido == id);
        }

        public void Cadastrar(CadastrarItemPedidoDTO itempedido)
        {
            Itempedido ItemPedidoCadastrado = new Itempedido

            {
                IdItemPedido = itempedido.IdPedido,
                IdPedido = itempedido.IdPedido,
                IdProduto = itempedido.IdProduto,
                Quantidade = itempedido.Quantidade,
                
            };

            _context.Itempedidos.Add(ItemPedidoCadastrado);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            
            Itempedido ItemPedidoCadastrado = _context.Itempedidos.Find(id);

            
            if (ItemPedidoCadastrado == null)
            {
                throw new Exception();
            }
            // Caso eu encontre o produto, removo ele
            _context.Itempedidos.Remove(ItemPedidoCadastrado);

            // salvo as alterações
            _context.SaveChanges();
        }

        public List<Itempedido> ListarTodos()
        {
            return _context.Itempedidos.ToList();
        }

    }
    
}
