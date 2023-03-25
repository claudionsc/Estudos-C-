using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exceções.Models
{
    public class Ex
    {
        
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            // trow joga o erro para outro bloco de código e para ser tratado
            throw new Exception("Ocorreu uma exceção");
        }
    }

}