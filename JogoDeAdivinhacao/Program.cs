/* Jogo de Adivinhação
Gere um número aleatório entre 1 e 100. Dê ao usuário até 7 tentativas para adivinhar. Mostre mensagens de "maior" ou "menor" para ajudar. */
Console.WriteLine("\nJogo de ADIVINHAÇÃO");
Console.WriteLine("---------------------\n");

//Criando os números aleatórios. Agora entendi como funciona, você tem que usar o .Next(valormáximo)
var randNumero = new Random();
//Escolhendo o número aleatório
var numeroAleatorio = randNumero.Next(101);
//Console.WriteLine(numeroAleatorio); // teste

Console.WriteLine("Irei gerar um número aleatório entre 1 e 100 e você terá que adivinhar!\n");
Console.WriteLine("Você possui apenas 7 tentativas!\n");


//Try -> para casos especiais em que o usuário erre o tipo de entrada.
try
{
    for (int i = 0; i < 7; i++)
    {
        Console.Write($"{i + 1}º tentativa: ");
        var tentativa = Convert.ToInt32(Console.ReadLine());

        if (tentativa > numeroAleatorio)
        {
            Console.WriteLine("É um número menor...\n");
        }
        else if (tentativa < numeroAleatorio)
        {
            Console.WriteLine("É um número maior...\n");
        }

        if (tentativa == numeroAleatorio)
        {
            Console.WriteLine($"\nACERTOU!!! O número correto é {tentativa}!");
            Console.WriteLine($"Parabéns!!! Você terminou o jogo com {i + 1} tentativas.\n");
            break;
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Favor inserir um valor válido...");
}
