using System.Collections.Generic;
using System;

namespace Carrinho
{
    public class Carrinho
    {
        
        //Criei a variável para o valor total do produto.
        public float ValorTotal { get; set; }

        //Criei uma lista de produtos para o carrinho.
        List<Produto> carrinho = new List<Produto>();

        //Variável para a adição do produto.
        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        //Variável para a exclusão de um ou mais produtos.
        public void ExcluirProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        //Leitura dos produtos para o usuário.
        public void MostrarProdutos()
        {
            if(carrinho != null){
                foreach(Produto p in carrinho){

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Nome: {p.Nome} - Preço: {p.Preco}");
                    Console.ResetColor();

                }
            }
        }

        //Valor total dos produtos.
        public void MostrarValorTotal()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            if(carrinho != null){

                foreach(Produto p in carrinho){

                ValorTotal += p.Preco;

                }   
            Console.WriteLine($"\nO valor total é igual a: {ValorTotal}");
            Console.ResetColor();

            }else{

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O seu carrinho está vazio!");
                
            }
        }

        //Update em um ou mais produtos.
        public void AlterarProduto(int _codigo, Produto _novoproduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoproduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoproduto.Preco;
        }



    }
}