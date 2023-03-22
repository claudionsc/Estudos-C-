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
    }
}