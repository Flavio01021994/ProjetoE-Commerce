using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;

namespace ECommerceAPI.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        // Métodos que acessam o Banco Banco de Dados
        // Injetar o Context
        // Inteção de Dependencia
        private readonly EcommerceContext _context;

        // ctor
        // metodo construtor
        //Quando criar um objeto o que eu preciso ter?
        public ProdutoRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, Produto produto)
        {
            // Encontro o produto que desejo
            Produto produtoEncontrado = _context.Produtos.Find(id);

            produtoEncontrado.Nome = produto.Nome;
            produtoEncontrado.Descricao = produto.Descricao;
            produtoEncontrado.Preco = produto.Preco;
            produtoEncontrado.Categoria = produto.Categoria;
            produtoEncontrado.Imagem = produto.Imagem;
            produtoEncontrado.EstoqueDisponivel = produto.EstoqueDisponivel;

            _context.SaveChanges();
        }

        public Produto BuscarPorId(int id)
        {
            // ToList() - Pegar varios
            //FirstorDefault - Trazer o primeiro que encontrar ou null

            // Expressao Lambda
            //_context.Produtos - Acesse a tabela produto do contexto
            // FirstOrDefault - Pegue o primeiro produto que encontrar
            // p => p.IdProduto == id 
            // para cada produto p, me retorne aquele que tem o IdProduto igual ao id
            return _context.Produtos.FirstOrDefault(p=> p.IdProduto == id);
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            // 1 - Encontrar o que eu quero excluir
            // Find - procura pela chave primaria
            Produto produtoEncontrado = _context.Produtos.Find(id);

            // Caso eu nao encontre o produto, lanco o erro
            if (produtoEncontrado == null)
            {
                throw new Exception();
            }
            // Caso eu encontre o produto, removo ele
            _context.Produtos.Remove(produtoEncontrado);

            // salvo as alterações
            _context.SaveChanges();
        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList();
        }
    }
}
