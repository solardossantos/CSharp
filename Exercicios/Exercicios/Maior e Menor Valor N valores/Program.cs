﻿int num = 0;
var maiorNumero = 0;
var menorNumero = 10000;
        
do
{
    Console.WriteLine("Informe um numero (ou 0 para sair): ");
    num = int.Parse(Console.ReadLine());

    if (num == 0)
    {
        Console.WriteLine($"O maior numero é {maiorNumero}");
        Console.WriteLine($"O menor numero é {menorNumero}");
    } else if (num > maiorNumero)
    {
        maiorNumero = num;
    } else if (num < menorNumero)
    {
        menorNumero = num;
    }
} while (num != 0);


/*
int x = 12;
bool entre = (x > 25) && (x < 40); // False
bool ou = (x > 25) || (x < 40); // True
bool negação = !(x < 25); // False */

