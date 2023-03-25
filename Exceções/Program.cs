

try
{
// A classe File lida com arquivos, read lê um arquivo
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }

} catch(Exception ex)
{
        Console.WriteLine($"Ocorreu uma exceção genérica\n {ex.Message}");   
}