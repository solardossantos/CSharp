//Faça um programa que solicite do usuario dois numeros e qual ação ele deseja executar entre soma, divisão, multiplicação e subtração

// Escrevendo a tela
Tela();
Soma();
Subtracao();
Divisao();
Multiplicacao();

static void Tela()
{
    Console.Clear();
    Console.WriteLine("Informe qual ação você deseja executar:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("0 - Exit");
    var acao = int.Parse(Console.ReadLine());

    switch (acao)
    {
        case 0: System.Environment.Exit(0);
            break;
        case 1: Soma();
            break;
        case 2: Subtracao();
            break;
        case 3: Divisao(); 
            break;
        case 4: Multiplicacao();
            break;
    }
    
}

static void Soma()
{
    Console.Clear();
    
    Console.WriteLine("Informe um número:");
    float n1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe outro número:");
    float n2 = float.Parse(Console.ReadLine());

    float res = n1 + n2;
    Console.WriteLine($"O resultado da some entre {n1} e {n2} é igual a {res}");
    Console.ReadKey();
    Tela();
}

static void Subtracao()
{
    Console.Clear();
    
    Console.WriteLine("Informe um número:");
    float n1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe outro número:");
    float n2 = float.Parse(Console.ReadLine());

    float res = n1 - n2;
    
    Console.WriteLine($"O resultado da subtracao entre {n1} e {n2} é igual a {res}");
    Console.ReadKey();
    Tela();
}

static void Divisao()
{
    Console.Clear();
    
    Console.WriteLine("Informe um número:");
    float n1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe outro número:");
    float n2 = float.Parse(Console.ReadLine());

    float res = n1 / n2;
    
    Console.WriteLine($"O resultado da divisão entre {n1} e {n2} é igual a {res}");
    Console.ReadKey();
    Tela();
}

static void Multiplicacao()
{
    Console.Clear();
    
    Console.WriteLine("Informe um número:");
    float n1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe outro número:");
    float n2 = float.Parse(Console.ReadLine());

    float res = n1 * n2;
    
    Console.WriteLine($"O resultado da multiplicacão entre {n1} e {n2} é igual a {res}");
    Console.ReadKey();
    Tela();
}



