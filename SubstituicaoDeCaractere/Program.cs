/* Substituição de Caracteres em Strings
Peça uma frase ao usuário e um caractere para substituir. Depois, peça um caractere de substituição e exiba a nova frase. */

using System.Globalization;

Console.WriteLine("\n SUBSTITUIDOR DE CARACTERES 3000");
Console.WriteLine("----------------------------------\n");

Console.Write("Digite uma frase: ");
var frase = Console.ReadLine();
Console.Write("\nÓtimo, agora escolha um caractere que deseja substituir nessa frase: ");
var caracter = Console.ReadLine();
Console.Write("\nCerto, deseja substituir por qual letra: ");
var caracterTrocado = Console.ReadLine();

for (int i = 0; i < frase.Length; i++)
{
    if (caracter.Contains(frase[i]))
    {
        frase = frase.Replace(caracter, caracterTrocado);
    }
}
Console.WriteLine(frase);