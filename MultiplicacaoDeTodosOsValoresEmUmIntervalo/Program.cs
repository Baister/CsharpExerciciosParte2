/* Multiplicação de Todos os Valores em um Intervalo
Receba dois números do usuário e exiba o produto de todos os números inteiros nesse intervalo. */

using System.Globalization;

Console.WriteLine("\nMULTIPLICADOR 3000");
Console.WriteLine("------------------\n");

Console.Write("Digite um número: ");
var primeiroValor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Digite outro número: ");
var segundoValor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nAgora vou exibir o produto de todos os números inteiros nesse intervalo...\n");

// Garantindo que o primeiro valor seja sempre o menor
int inicio = Math.Min(primeiroValor, segundoValor);
int fim = Math.Max(primeiroValor, segundoValor);

long produto = 1; // Variável para armazenar o produto

for (int i = inicio; i <= fim; i++)
{
    produto *= i;
}

Console.WriteLine($"O produto de todos os números entre {inicio} e {fim} é: {produto}");