/* Conversor de Base Numérica
Receba um número decimal do usuário e mostre sua representação em binário e hexadecimal. */

Menu();

static void Menu()
{

    Console.WriteLine("Conversor de Base Númerica 3000");
    Console.WriteLine("-------------------------------\n");
    Console.Write("Digite um número decimal e mostrarei a representação em binário e hexadecimal: ");
    int numUsuario = int.Parse(Console.ReadLine()); // Variável em decimal

    Binario(numUsuario);

}

static void Binario(int num)
{
    //Preciso criar uma lista
    List<int> binarios = [];

    var divid = num;
    var resto = divid % 2;



    //Preciso criar um loop
    while (divid != 0)
    {
        binarios.Add(resto); // Que é o primeiro valor do resto da divisão;
        Console.WriteLine($"Quosciente: {divid}. Resto: {resto}");
        divid /= 2;
        resto = divid % 2; // Daí o valor do divisor sempre vai mudar com o resto
    }

    //Adicionando o resto a lista
    //binarios.Add(resto);
    //Agora preciso inverter a lista
    binarios.Reverse();
    //Vou criar uma nova lista
    string binarioInverso = "";

    foreach (int bin in binarios)
    {
        binarioInverso += bin;
    }

    Console.WriteLine($"Temos a representação binária de {num}: {binarioInverso}");
    Console.ReadKey();
}