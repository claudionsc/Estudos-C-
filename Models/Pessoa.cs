using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// digitar prop e clicar em tab faz com que o sistema complete o 
// código automaticamente

namespace Estudos_C_.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos")
        }
    }
}