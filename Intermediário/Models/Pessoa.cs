using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intermediário.Models
{
    public class Pessoa
    {
        private string _nome; // campo criado para encapsulamento (proteção, validação de métodos)
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

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}