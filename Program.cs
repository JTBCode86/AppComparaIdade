using System;

namespace AppComparaIdade
{
    /// <summary>
    /// Exercicios - Classes
    /// Programa para verificar quem possui é a pessoa mais velha.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Entre com sues dados da primeira pessoa, Nome e Idade");
            string[] vet = Console.ReadLine().Split(" ");
            
            pessoa1.nome = vet[0];
            pessoa1.idade = int.Parse(vet[1]);
            
            Console.WriteLine("Entre com sues dados da segunda pessoa, Nome e Idade");
            string[] vet2 = Console.ReadLine().Split(" ");
            pessoa2.nome = vet2[0];
            pessoa2.idade = int.Parse(vet2[1]);

            if (pessoa1.idade> pessoa2.idade)
            {
                Console.WriteLine("A pessoa mais velha é: {0}", pessoa1.nome.ToString());
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: {0}", pessoa2.nome.ToString());
            }
            Console.ReadLine();
        }
    }
}
