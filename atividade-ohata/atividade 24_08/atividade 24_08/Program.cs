using System;

namespace atividade_24_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            double idade1;
            string nome2;
            double idade2;

            Console.WriteLine("digite o nome, e idade, respectivamente da pessoa 1");
            Console.WriteLine("nome:");
                     nome1 = Console.ReadLine();
            Console.WriteLine("idade:");
                     idade1 = double.Parse(Console.ReadLine());

            Console.WriteLine("agora digite os mesmos dados, referentes a segunda pessoa");
            Console.WriteLine("nome:");
                     nome2 = Console.ReadLine();
            Console.WriteLine("idade:");
                     idade2 = double.Parse(Console.ReadLine());

            if (idade1 > idade2)
                Console.WriteLine(nome1 + "é a pessoa mais velha");
            else
                Console.WriteLine(nome2 + "é a pessoa mais velha");


           



        }
    }
}
