try
{
    string[] linha = File.ReadAllLines("arquivo/arq_.txt");

    foreach (string s in linha)
    {
        Console.WriteLine(s);
    }
} catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}