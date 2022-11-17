// See https://aka.ms/new-console-template for more information

Console.WriteLine("Informe a primeira nota:");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota:");
int n2 = int.Parse(Console.ReadLine());

float res = (n1 + n2) / 2; 

Console.WriteLine($"A média entre {n1} e {n2} é {res}");
Console.ReadLine();
