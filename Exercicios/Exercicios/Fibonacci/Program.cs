// Faça um programa que gere a sequência de Fibonacci

Console.WriteLine("informe a quantidade de números a ser imprimido:");
int quantidade = int.Parse(Console.ReadLine());
Console.WriteLine();
Fibo(1, quantidade, 0, 1);

static int Fibo(int num1, int quantidade, int aux, int i)
{
    if (i > quantidade)
    {
        return num1;
    }

    Console.WriteLine(num1);
    var result = num1 + aux;
    aux = num1;
    num1 = result;
    i++;
    return Fibo(result, quantidade, aux, i);
}
