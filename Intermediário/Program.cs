using Intermediário.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Claudio";
pessoa1.Sobrenome = "Nascimento";


Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Gabriel";
pessoa2.Sobrenome = "Alvi";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.addAluno(pessoa1);
cursoDeIngles.addAluno(pessoa2);
cursoDeIngles.ListarAlunos();

