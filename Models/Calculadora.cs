using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio_Bootcamp_Pottencial_.NET_Developer.Models
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
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void Seno (double angulo)
        {
            double radiano = angulo * Math.PI/180;
            double sin = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(sin,4)}");
        }
         public void Cosseno (double angulo)
        {
            double radiano = angulo * Math.PI/180;
            double cos = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(cos,4)}");
        }
         public void Tangente (double angulo)
        {
            double radiano = angulo * Math.PI/180;
            double tan = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tan,4)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);        
            Console.WriteLine($"Raiz Quadrada de {x} = {raiz}");
        }
    }
}