//Fazendo uma calculadora Com apenas dois valores
var continuar = true;
while (continuar)
{
    Console.Clear();
    Console.WriteLine("Calculadora .exe");
    Console.WriteLine("----------------\n");

    Console.WriteLine("Escolha a operação que deseja realizar:");
    Console.WriteLine("[1] Soma\n[2]Subtração\n[3]Multiplicação\n[4]Divisão");
    Console.WriteLine("");
    Console.Write("Digite: ");

    var escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            Soma();
            break;
        case "2":
            Subtrair();
            break;
        case "3":
            Multiplicacao();
            break;
        default:
            Divisao();
            break;
    }
    try
    {
        Console.Write("Deseja continuar? [S/N]: ");
        var parar = char.Parse(Console.ReadLine().ToLower());
        if (parar == 'n')
        {
            continuar = false;
            Console.WriteLine("Finalizando...");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, inserir um valor válido!");
    }


}



void Soma()
{
    Console.Write("\nDigite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 + v2;

    Console.WriteLine("");
    Console.WriteLine($"O resultado da SOMA é {resultado}");
}

void Subtrair()
{
    Console.Write("\nDigite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 - v2;

    Console.WriteLine("");
    Console.WriteLine($"O resultado da SUBTRAÇÃO é {resultado}");
}

void Multiplicacao()
{
    Console.Write("\nDigite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 * v2;

    Console.WriteLine("");
    Console.WriteLine($"O resultado da MULTIPLICAÇÃO é {resultado}");
}

void Divisao()
{
    Console.Write("\nDigite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 / v2;

    Console.WriteLine("");
    Console.WriteLine($"O resultado da DIVISÃO é {resultado}");
}