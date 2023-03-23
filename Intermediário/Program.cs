using Intermediário.Models;

// ALTERANDO A LOCALIZAÇÃO DO CÓDIGO ====================================
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// ====================================================================== 



// Pessoa pessoa1 = new Pessoa(nome: "Claudio", sobrenome: "Nascimento");

// Pessoa pessoa2 = new Pessoa(nome: "Gabrie", sobrenome: "Alvi");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.addAluno(pessoa1);
// cursoDeIngles.addAluno(pessoa2);
// cursoDeIngles.ListarAlunos();

// FORMATANDO VALORES MONETÁRIOS =================================

decimal valorMonetario = 1582.40M;
decimal valorDolar = 2585.50M;


// : significa que é desejado formatar uma string . C significa Currency
Console.WriteLine($"{valorMonetario:C}");
// alterando localização da cultura mesmo ela ja sendo definida como outra
Console.WriteLine(valorDolar.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));


