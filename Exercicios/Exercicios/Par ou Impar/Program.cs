﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Informe um número inteiro:");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"O número {num} é par");
}
else
{
    Console.WriteLine($"O número {num} é ímpar");
}
Console.ReadLine();