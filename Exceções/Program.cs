using Exceções.Models;
using System.Globalization;

// A classe File lida com arquivos, read lê um arquivo

string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach(string linha in linhas)
{
    Console.WriteLine(linha);
}