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

// Queue<int> fila = new Queue<int>();

// // ADD NA FILA

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// // REMOVER DA FILA -  REMOVE SEMPRE O PRIMEIRO ELEMENTO DA FILA

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// PILHAS =======================================================

// Stack<int> pilha = new Stack<int>();

// // ADD NA PILHA

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// //  REMOVER DA PILHA -  REMOVE SEMPRE O ÚLTIMO DA PILHA

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// DICTIONARY - COLEÇÃO CHAVEADA COM APENAS ELEMENTOS ÚNICOS ===================== 

Dictionary<string, string> estados = new Dictionary<string, string>();

// ADD NO DICTIONARY
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

// Percorrendo o dictionary

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// REMOVENDO/ALTERANDO ELEMENTOS DO DICTIONARY - OBS: SÓ É POSSÍVEL ALTERAR O VALOR, ENÃO A CHAVE

estados.Remove("SP");

Console.WriteLine("===========================");

estados["MG"] = "Minas -  valor alterado";

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// VERIFICANDO SE JÁ EXISTE CHAVE 

string chave = "BA2";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
} 
else 
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}

// Retornar valor existente no dictionary

Console.WriteLine($"Estado: {estados["MG"]}");