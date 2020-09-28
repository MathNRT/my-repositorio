using System;

namespace atividade_ohata_24_8_parte_2
{
    class Program
    {
        static void Main(string[] args) 
        {

            double media;

            func f1 = new func(); 

            Console.WriteLine("digite o nome e salario respectivamente de um funcionario");
            Console.WriteLine("nome:");
                  f1.nome = Console.ReadLine();
            Console.WriteLine("salario:");
                  f1.salario = double.Parse(Console.ReadLine());


            func f2 = new func();
            Console.WriteLine("agora faça a mesma coisa, com informaçoes referentes ao outro funcionario");
            Console.WriteLine("nome");
                  f2.nome = Console.ReadLine();
            Console.WriteLine("salario");
                  f2.salario = double.Parse(Console.ReadLine());



            media = (f1.salario + f2.salario) / 2;
            Console.WriteLine("a media salarial é " + media);


        
        }
    }
}
