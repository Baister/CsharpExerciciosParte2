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
            Console.WriteLine("3 - Multiplicação ");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            //Essa variável abaixo será para a escolha do usuário
            Console.Write("\nDigite a operação que deseja realizar: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Soma(); break;

                case 2: Subtracao(); break;

                case 3: Multiplicacao(); break;

                case 4: Divisao(); break;

                case 0: Sair(); break;

                default: System.Environment.Exit(); break;
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

        static void Multiplicacao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            decimal primeiroValor = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            decimal segundoValor = decimal.Parse(Console.ReadLine());
            //Só para deixar mais organizado, irei utilizar uma variável.
            var resultado = primeiroValor * segundoValor;

            Console.WriteLine($"O resultado da multiplicação entre {primeiroValor} e {segundoValor} resultou: {resultado}");
            //Retornando ao Menu após a resolução, só que antes disso, a pessoa dá um enter ou qualquer coisa pra voltar
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            decimal primeiroValor = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            decimal segundoValor = decimal.Parse(Console.ReadLine());
            //Só para deixar mais organizado, irei utilizar uma variável.
            var resultado = primeiroValor / segundoValor;

            Console.WriteLine($"O resultado da divisão entre {primeiroValor} e {segundoValor} resultou: {resultado}");
            //Retornando ao Menu após a resolução, só que antes disso, a pessoa dá um enter ou qualquer coisa pra voltar
            Console.ReadKey();
            Menu();
        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Finalizando...");
            Thread.Sleep(1500); // Só para dar aquele efeitinho de finalização hehe ficou bom
            System.Environment.Exit(0);
        }
    }
}