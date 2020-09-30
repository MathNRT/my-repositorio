using System;
using System.Globalization;

namespace Exercício_individual_Aula_31_08
{
    class Program
    {
        static void Main(string[] args)
        {
            produto p1 = new produto();
            string dados = ("Produto: " + p1.nome + ", Valor: " + p1.preco.ToString("f2", CultureInfo.InvariantCulture) + ", Quantidade: " + p1.estoque);
            double soma;
            double subtracao;


            Console.WriteLine("entre com os dados do produto");
            Console.WriteLine("nome do produto");
                  p1.nome = Console.ReadLine();
            Console.WriteLine("preço do produto");
                  p1.preco = double.Parse(Console.ReadLine());
            Console.WriteLine("quantidade em estoque");
                  p1.estoque = double.Parse(Console.ReadLine());

            Console.WriteLine("Produto: " + p1.nome + ", Valor: " + p1.preco.ToString("f2", CultureInfo.InvariantCulture) + ", Quantidade: " + p1.estoque);
            Console.WriteLine("digite um numero a ser adicionado no estoque");
                  soma = double.Parse(Console.ReadLine());
                  p1.estoque = (p1.estoque + soma);
            Console.WriteLine("Produto: " + p1.nome + ", Valor: " + p1.preco.ToString("f2", CultureInfo.InvariantCulture) + ", Quantidade: " + p1.estoque);
            Console.WriteLine("agora digite um numero a ser removido do estoque");
            subtracao = double.Parse(Console.ReadLine());
            p1.estoque = (p1.estoque - subtracao);
            Console.WriteLine("dados finais: ");
            Console.WriteLine("Produto: " + p1.nome + ", Valor: " + p1.preco.ToString("f2", CultureInfo.InvariantCulture) + ", Quantidade: " + p1.estoque);

            
           
            
            
            
            Console.ReadKey();
        }
    }
}
