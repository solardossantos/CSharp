// See https://aka.ms/new-console-template for more information

Console.WriteLine("Informe a primeira nota:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o peso da primeira nota:");
float p1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota:");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o peso da segunda nota:");
float p2 = float.Parse(Console.ReadLine());

float res = ((n1 * p1) + (n2 * p2)) / (p1 + p2);

Console.WriteLine($"A média Ponderada de {n1} com peso {p1} e {n2} com peso {p2} é igual a {res}");


