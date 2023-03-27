using Exceções.Models;

// try
// {
// // A classe File lida com arquivos, read lê um arquivo
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// } catch(FileNotFoundException ex)
// {
//         Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado\n {ex.Message}");   
// } catch(Exception ex)
// {
//         Console.WriteLine($"Ocorreu uma exceção genérica\n {ex.Message}");   
// } finally //executa um bloco de código independente se ocorreu erro ou não
// {
//         Console.WriteLine("Chegou até aqui");   
    
// }

// new Ex().Metodo1(); 

// FILAS =======================================================

Queue<int> fila = new Queue<int>();

// ADD NA FILA

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

// REMOVER DA FILA -  REMOVE SEMPRE O PRIMEIRO ELEMENTO DA FILA

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach(int item in fila)
{
    Console.WriteLine(item);
}