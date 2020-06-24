using System;

namespace Carrinho
{
    class Program
    {
        static void Main(string[] args)
        {
            
           //Criei alguns produtos
           Produto p1 = new Produto(1, "Stardew Valley", 25.99f);
           Produto p2 = new Produto(2, "Hollow knight", 29.99f);
           Produto p3 = new Produto(3, "Mario deluxe (switch edition)", 149.99f);
           Produto p4 = new Produto(4, "Zelda breath of the wild", 25.99f);

           Carrinho carrinho = new Carrinho();
           carrinho.AdicionarProduto(p1);
           carrinho.AdicionarProduto(p2);
           carrinho.AdicionarProduto(p3);
           carrinho.AdicionarProduto(p4);

           carrinho.ExcluirProduto(p2);

           Produto p5 = new Produto(1, "Rainbow Six Siege", 49.99f);
           carrinho.AlterarProduto(4, p5);

           carrinho.MostrarProdutos();

           carrinho.MostrarValorTotal();

        }
    }
}
