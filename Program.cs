// See https://aka.ms/new-console-template for more information
// uma classe é onde será codificado, ou seja, o arquivo com os códigos

// importar o namespace onde está a classe pessoa
using  Estudos_C_.Models;

// criar uma nova instância da classe pessoa
Pessoa pessoa1 = new Pessoa(); //essa é uma variável

pessoa1.Nome = "Gabriel";
pessoa1.Idade = 26;
pessoa1.Apresentar();

// usando o DateTime para pegar a data e hora atual do pc
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

DateTime dataAtual2 = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual2);

DateTime dataAtual3 = DateTime.Now;
Console.WriteLine(dataAtual3.ToString("dd/mm/yy"));


