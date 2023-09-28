using ExemploExplorando.Models;
using Newtonsoft.Json;
using System.Globalization;
using System.Text.Json.Nodes;



string conteudoArquivo = File.ReadAllText("Arquivo/vendas.json");


List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);


foreach (Venda venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto},"+
     $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}











// List<Venda> listaVendas = new List<Venda>();

// DateTime dataAtual = DateTime.Now;

// Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivo/vendas.json",serializado);



























// int numero = 20;


// //IF Ternário

// Console.WriteLine($"O número {numero} é {(numero%2==0 ? "par":"Ímpar")}");





// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }
























// Pessoa p1 = new Pessoa("Vitor", "Bittencourt");

// (string nome, string sobrenome) = p1;


// Console.WriteLine(nome + " " +sobrenome);














// LeituraArquivo arquivo = new LeituraArquivo();


// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("ARQUIVO/arq.txt");

// if (sucesso)
// {
//     //  Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeDeLinhas}");
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }


















// (int id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "vitor", "Bittencourt", 10.5M);
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "vitor", "Bittencourt", 10.5M);
// var tuple = Tuple.Create(1,"vitor","kk");

// Console.WriteLine($"ID: {tupla.id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"altura: {tupla.Altura}");

























// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP","São Paulo");
// estados.Add("BA","Bahia");
// estados.Add("RJ","Rio de Janeiro");


// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("BA");
// estados["SP"] = estados["SP"] + " - Estado alterado!";
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.TryAdd("SP", "saopaulo");
// Console.WriteLine("--------------------------");
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


















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