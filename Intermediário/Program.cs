using Intermediário.Models;

Pessoa pessoa1 = new Pessoa(nome: "Claudio", sobrenome: "Nascimento");

Pessoa pessoa2 = new Pessoa(nome: "Gabrie", sobrenome: "Alvi");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.addAluno(pessoa1);
cursoDeIngles.addAluno(pessoa2);
cursoDeIngles.ListarAlunos();

