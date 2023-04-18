using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudy.POO.Delegates
{
    public class Calculadora
    {
        public delegate void OperacaoMatematica(int a, int b);

        public void Somar(int a, int b)
        {
            Console.WriteLine($"A soma de {a} e {b} é {a + b}");
        }

        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"A subtração de {a} e {b} é {a - b}");
        }

        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"A multiplicação de {a} e {b} é {a * b}");
        }

        public void Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            else
            {
                Console.WriteLine($"A divisão de {a} por {b} é {a / b}");
            }
        }
    }
}
