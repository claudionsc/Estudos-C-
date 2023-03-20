// See https://aka.ms/new-console-template for more information
// uma classe é onde será codificado, ou seja, o arquivo com os códigos

// importar o namespace onde está a classe pessoa
using  Estudos_C_.Models;

// criar uma nova instância da classe pessoa
// Pessoa pessoa1 = new Pessoa(); //essa é uma variável

// pessoa1.Nome = "Gabriel";
// pessoa1.Idade = 26;
// pessoa1.Apresentar();

// // usando o DateTime para pegar a data e hora atual do pc
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);

// DateTime dataAtual2 = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual2);

// DateTime dataAtual3 = DateTime.Now;
// Console.WriteLine(dataAtual3.ToString("dd/mm/yy"));

// // Converter string em inteiro

// int a = Convert.ToInt32("5"); // valores nulos retornam 0
// int b = int.Parse("15"); // valores nulos dão erro na execução

// Console.WriteLine(a);
// Console.WriteLine(b);

// int inteiro = 5;
// string a  = inteiro.ToString();
// Console.WriteLine(a);


// // TryParse para mostrar um log caso dê erro na conversão de tipos
// string a = "15-"; 

// int b = 0;

// int.TryParse(a, out b); // valor a parsear e qual o resultado de saída caso de erro

// Console.WriteLine(b);

// int qtdEstoque = 10;

// int qdtCompra = 0;

// if(qdtCompra == 0){
//     Console.WriteLine("Venda não realizada");
// }
// else if(qtdEstoque >= qdtCompra)
// {
//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Não tem no estoque");
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//     Console.WriteLine("Não é uma vogal");
//     break;
// }


Calculadora calc = new Calculadora();
// // calc.Somar(10, 30);
// // calc.Subtrair(30, 10);
// // calc.Multiplicar(10, 30);
// // calc.Dividir(30, 10);
// calc.Potencia(3, 3);

// FUNÇÕES TRIGONOMÉTRICAS =================================================
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);

// INCREMENTO E DECREMENTO =======================================

// int numero = 10;

// Console.WriteLine($"Incrementando o {numero}");

// numero++;

// Console.WriteLine(numero);

// Console.WriteLine($"Decrementando o {numero}");

// numero--;

// Console.WriteLine(numero);

// RAIZ QUADRADA ========================================================
// calc.RaizQuadrada(144);

// ESTRUTURAS DE REPETIÇÃO ==============================================

// int numero = 5;

// FOR ====

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// WHILE ============

// int contador = 0;

// while(contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     // obs, pode quebrar o laço apenas usando o break com uma condicional
// }

// DO WHILE - A VERIFICAÇÃO É EXECUTADA AO FINAL DO CÓDIGO ============


int soma = 0, numero = 0;
do
{
    Console.WriteLine($"Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while(numero != 0);

Console.WriteLine($"Total das somas dos números digitados é: {soma}");











