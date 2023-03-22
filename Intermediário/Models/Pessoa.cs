using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intermediário.Models

// Public significa que qualquer um pode acessar a classe/propriedade
// Private significa que apenas é acessível dentro da própria classe

{
    public class Pessoa
    {
        private string _nome; // isso é um campo, criado para encapsulamento (proteção, validação de métodos)
        private int _idade;

        public string Nome 
        { 
            get => _nome.ToUpper();
            
            set // ao atribuir um valor, passe a condicional...
            {
               if(value == "") 
               {
                    throw new ArgumentException("O nome não pode ser vazio");
               }
               _nome = value;
            }
        } //essas são propriedades
        public int Idade 
        { 
            get => _idade;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public string Sobrenome { get; set; }

        // propriedade somente leitura
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // não faz sentido essa ter um set, pois os dados ja foram criados antes
        
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}