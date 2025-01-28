/* Cálculo de Média Ponderada
Receba 3 números e seus respectivos pesos. Calcule e exiba a média ponderada. */
/* Console.WriteLine("\nEscola HIGH SCHOOL MUSICAL");
Console.WriteLine("-------------------------------\n");

Console.Write("Digite a nota da A1: ");
var notaA1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("\nDigite a nota A2: ");
var notaA2 = Convert.ToDecimal(Console.ReadLine());
Console.Write("\nDigite a nota A3: ");
var notaA3 = Convert.ToDecimal(Console.ReadLine());


decimal MediaPonderada(decimal valor1, decimal valor2, decimal valor3)
{
    decimal media = (valor1 * 30 + valor2 * 30 + valor3 * 40) / 100;
    return media;
}

Console.WriteLine($"\nA média ficou {MediaPonderada(notaA1, notaA2, notaA3)}"); */
try
{
    Console.WriteLine("\nMEDIA PONDERADA");
    Console.WriteLine("------------------\n");

    Console.Write("\nDigite o primeiro valor: ");
    var valor1 = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Agora o seu respectivo peso: ");
    var peso1 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("\nDigite o segundo valor: ");
    var valor2 = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Agora o seu respectivo peso: ");
    var peso2 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("\nDigite o terceiro valor: ");
    var valor3 = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Agora o seu respectivo peso: ");
    var peso3 = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine($"\n A média final ficou {MediaPonderada(valor1, valor2, valor3, peso1, peso2, peso3)}"); // O código tá funcionando.
}
catch (FormatException)
{
    Console.WriteLine("Favor inserir um valor válido...");
}


decimal MediaPonderada(decimal valor1, decimal valor2, decimal valor3, decimal peso1, decimal peso2, decimal peso3)
{
    decimal media = (valor1 * peso1 + valor2 * peso2 + valor3 * peso3) / (peso1 + peso2 + peso3);
    return media;
}

