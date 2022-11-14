// Armazenando valores

Console.WriteLine("Informe o primeiro valor:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo valor:");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro valor:");
float n3 = float.Parse(Console.ReadLine());

float maiorValor = 0;

// Criando a lógica de maiorValor

if (n1 > n2 && n1 > n3)
{
    maiorValor = n1;
}

else if (n2 > n1 && n2 > n3)
{
    maiorValor = n2;
}

else
{
    maiorValor = n3;
}

// Criando a lógica de menorValor
float menorValor = 0;


if (n1 < n2 && n1 < n3)
{
    menorValor = n1;
}

else if (n2 < n1 && n2 < n3)
{
    menorValor = n2;
}

else
{
    menorValor = n3;
}

// Exibindo o resultado final

Console.WriteLine($"O maior valor entre {n1}, {n2} e {n3} é {maiorValor}");
Console.WriteLine($"O menor valor entre {n1}, {n2} e {n3} é {menorValor}");
Console.ReadLine();