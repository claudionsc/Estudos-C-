using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intermediário.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void addAluno(Pessoa aluno)// para add um aluno, é preciso dizer de onde ele vem
        {
            Alunos.Add(aluno);
        }

        public int ObterQtdAlunosMatriculados()
        {
            int qtd = Alunos.Count;
            return qtd;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}