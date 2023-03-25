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

// decimal valorMonetario = 1582.40M;
// decimal valorDolar = 2585.50M;


// // : significa que é desejado formatar uma string . C significa Currency
// Console.WriteLine($"{valorMonetario:C}");
// // alterando localização da cultura mesmo ela ja sendo definida como outra
// Console.WriteLine(valorDolar.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// // REPRESENTANDO PORCENTAGEM ========================================
// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// // FORMATAÇÃO PERSONALIZADA =========================
// int num = 123456;
// Console.WriteLine(num.ToString("##-##-##"));


// FORMATANDO O TIPO DATETIME =========================================
DateTime data = DateTime.Now; // data atual do dispositivo
DateTime data2 = DateTime.Parse("11/05/2023 18:00"); // parseando string pra data

// parseando data que pode ser inválida para o tipo datetime
string dataString ="11/06/2023 18:00";
bool sucesso = DateTime.TryParseExact(dataString, 
                        "dd/MM/yyyy HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, 
                        out data); 

if (sucesso){
    Console.WriteLine($"Conversão com sucesso: {data}");
} else {
    Console.WriteLine($"{data} é data inválida");
}                 
// ==========================================================

// Console.WriteLine(data);
// Console.WriteLine(data.ToShortDateString()); // somente data
// Console.WriteLine(data.ToShortTimeString()); // somente hora
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
