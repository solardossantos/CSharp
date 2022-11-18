// See https://aka.ms/new-console-template for more information

/*
    Crie um programa que receba o nome completo de uma pessoa ex: Ilan Negreiros dos Santos
    * remova todos os espaços laterais 
    * remova todos os espaçoes entre os nomes
    * passe todas as letras para minusculo
    * passe todas as letras para maiusculo
    * adicione uma nova palavra ao nome
    * remova uma palavra do nome
    * pesquise uma palavra dentro do nome
    * informe a quantidade de letras no nome
   */
   
//Recebendo o nome completo
Console.WriteLine("Informe seu nome completo:");
string nomeCompleto = Console.ReadLine();

Console.Clear();

//Removendo os espaços laterais
Console.WriteLine(nomeCompleto.Trim());

//Removendo os espaços entre os nome
Console.WriteLine(nomeCompleto.Replace(" ", ""));

//Passe todas as letras para o minusculo
Console.WriteLine(nomeCompleto.ToLower());

//Passe todas as letras para maiusculo
Console.WriteLine(nomeCompleto.ToUpper());

//Adicione uma nova palavra ao nome
Console.WriteLine(nomeCompleto.Insert(nomeCompleto.Length, " O foda"));

//Remova uma palavra do nome
Console.WriteLine(nomeCompleto.Remove(15, 10));

//Pesquise uma palavra dentro do nome
Console.WriteLine(nomeCompleto.Contains("dos Santos"));

//Informe a quantidade de letras no nome
Console.WriteLine(nomeCompleto.Replace(" ", " ").Length);

Console.ReadKey();


