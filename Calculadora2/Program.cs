using System;

namespace Calculdora2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Calculadora 3000");
            Console.WriteLine("----------------");
            Console.WriteLine("1 - Soma ");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("0 - Sair");
            //Essa variável abaixo será para a escolha do usuário
            Console.Write("\nDigite a operação que deseja realizar: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Soma(); break;

                case 2: Subtracao(); break;

                case 0: System.Environment.Exit(0); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            int primeiroValor = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int segundoValor = int.Parse(Console.ReadLine());
            //Só para deixar mais organizado, irei utilizar uma variável.
            var resultado = primeiroValor + segundoValor;

            Console.WriteLine($"O resultado da soma entre {primeiroValor} e {segundoValor} resultou: {resultado}");
            //Retornando ao Menu após a resolução, só que antes disso, a pessoa dá um enter ou qualquer coisa pra voltar
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            int primeiroValor = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int segundoValor = int.Parse(Console.ReadLine());
            //Só para deixar mais organizado, irei utilizar uma variável.
            var resultado = primeiroValor - segundoValor;

            Console.WriteLine($"O resultado da subtração entre {primeiroValor} e {segundoValor} resultou: {resultado}");
            //Retornando ao Menu após a resolução, só que antes disso, a pessoa dá um enter ou qualquer coisa pra voltar
            Console.ReadKey();
            Menu();
        }
    }
}