// See https://aka.ms/new-console-template for more information
Console.Write("Qual é a idade? ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"A idade é: {idade}");

{

    if (idade >= 0 && idade <= 12)
    {
        Console.WriteLine("criança");
    }
    else if (idade >= 13 && idade <= 17)
    {
        Console.WriteLine("adolescente");
    }
    else if (idade >= 18 && idade <= 64)
    {
        Console.WriteLine("adulto");
    }
    else if (idade >= 65)
    {
        Console.WriteLine("idoso");
    }



    else
    {
        Console.WriteLine("erro: nenhum número informado");


    }


