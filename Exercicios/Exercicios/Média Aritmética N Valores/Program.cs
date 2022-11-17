var total = 0;
var contador = 0;
var n = 0;

do
{
    Console.WriteLine("Informe um valor (0 para sair):");
    n = int.Parse(Console.ReadLine());

    if (n == 0)
    {
      Console.WriteLine($"A média dos valores é {total/contador}");
      Console.ReadLine();
    }

    total += n;
    contador++;
    
} while (n != 0);
