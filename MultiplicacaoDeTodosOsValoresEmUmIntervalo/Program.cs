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

//Essa lista vai adicionar os valores que estão dentro do intervalo.
int[] listaDosNumerosIntervalo = new int[5];

while (segundoValor > primeiroValor)
{
    Console.WriteLine(segundoValor);

    segundoValor--; //Para controlar o Loop;
    for (int i = 0; i < segundoValor; i++)
    {
        listaDosNumerosIntervalo[i] = segundoValor;
    }

}
foreach (int num in listaDosNumerosIntervalo)
{
    Console.WriteLine(num);
}