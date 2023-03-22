using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intermediário.Models
{
    public class Pessoa
    {
        private string _nome; // campo criado para encapsulamento (proteção, validação de métodos)


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
            get; 
            set;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}