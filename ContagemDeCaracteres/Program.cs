/* Contagem de Caracteres Únicos
Peça uma palavra e exiba quantos caracteres únicos ela contém. Exemplo: "banana" tem 3 caracteres únicos: b, a, n. */

Console.WriteLine("\nCONTADOR DE CARACTERES ÚNICOS 3000");
Console.WriteLine("------------------------------------\n");

Console.Write("Digite uma palavra: ");
var palavra = Console.ReadLine().ToLower();

var caracteres = "";
//var alfabetoComVogais = "abcdefghijklmnopqrstuvwxyz"; //Em vez de alfabetoComVogais usar char.IsLetter
var contagem = 0;

for (int i = 0; i < palavra.Length; i++)
{
    //Se tem todas as letras do alfabeto
    if (char.IsLetter(palavra[i]))
    {   //Se NÃO tem o caracter que já foi marcado passará por esse IF
        if (!caracteres.Contains(palavra[i]))
        {   //Concatenando
            caracteres += Convert.ToString(palavra[i]);
            //Console.WriteLine(caracteres);//teste

            //Somando a contagem
            contagem++;

        }
    }
}
Console.WriteLine($"'{palavra}' tem {contagem} caracteres únicos: {caracteres}.");