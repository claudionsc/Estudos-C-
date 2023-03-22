using Intermediário.Models;

Pessoa pessoa1 = new Pessoa("Claudio", "Nascimento");

Pessoa pessoa2 = new Pessoa("Gabrie", "Alvi");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.addAluno(pessoa1);
cursoDeIngles.addAluno(pessoa2);
cursoDeIngles.ListarAlunos();

