using ExemploExplorando.Models;
using System.Globalization;
using System.Runtime.CompilerServices;


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP","São Paulo");
estados.Add("BA","Bahia");
estados.Add("RJ","Rio de Janeiro");


foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");
estados["SP"] = estados["SP"] + " - Estado alterado!";
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.TryAdd("SP", "saopaulo");
Console.WriteLine("--------------------------");
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}


















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int n in pilha)
// {
//     Console.WriteLine(n);
// }

// Console.WriteLine($"Removendo o elemento - {pilha.Pop()}");


// foreach (int n in pilha)
// {
//     Console.WriteLine(n);
// }

// pilha.Push(22);




















// Queue<int> file = new Queue<int>();

// file.Enqueue(2);
// file.Enqueue(24);
// file.Enqueue(26);
// file.Enqueue(8);


// foreach (int item in file)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento {file.Dequeue()}");


// foreach (int item in file)
// {
//     Console.WriteLine(item);
// }

















// new ExemploExcecao().Metodo1();



























// try
// {
//     string[] linha = File.ReadAllLines("arquivo/arq_.txt");

//     foreach (string s in linha)
//     {
//         Console.WriteLine(s);
//     }
// } 
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }