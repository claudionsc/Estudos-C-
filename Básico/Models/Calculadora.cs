using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos_C_.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y); //classe Math contém métodos avançados de matemática, Pow é potencia em ingles
            Console.WriteLine($"{x}^{y} = {potencia}");
        }

        // FUNÇÕES TRIGONOMÉTRICAS COM MATH (SEN, COS, TANG)

        public void Seno(double angulo)
        {
            /* para calcular o seno, é preciso criar 
            uma variável que calcula o radiano, usando o valor de pi */
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}");
        }
        public void Cosseno(double angulo)
        {
    
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo}º = {Math.Round(cosseno, 4)}");
        }
        public void Tangente(double angulo)
        {
    
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}");
        }

        // CALCULANDO RAIZ QUADRADA

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raíz quadrada de {x} = {raiz}");
        }
    }
}