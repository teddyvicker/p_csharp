using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp
{
    internal class Ex_Funcao
    {
        public static void Run()
        {
            Random rnd = new Random();
            int a = rnd.Next() % 100;
            int b = rnd.Next() % 50;

            int enumValue = (int)TipoOperacao.Multiplicar;

            Console.WriteLine($"A: {a},B: {b} , AxB: {Calcular(TipoOperacao.Multiplicar, a, b)}");

        }
        public static double Calcular(TipoOperacao op, int a, int b)
        {
            double resultado = 0;

            double Adicionar(double a, double b) { return (a + b); }
            double Subtrair(double a, double b) { return (a - b); }
            double Multiplicar(double a, double b) { return (a * b); }
            double Dividir(double a, double b) { return a / b; }

            switch (op)
            {
                case TipoOperacao.Multiplicar:
                    resultado = Multiplicar(a, b);
                    break;
                case TipoOperacao.Dividir:
                    resultado = Dividir(a, b);
                    break;
                case TipoOperacao.Somar:
                    resultado = Adicionar(a, b);
                    break;
                case TipoOperacao.Subtrair:
                    resultado = Subtrair(a, b);
                    break;
                default:
                    break;
            }
            
                    return resultado;
        }
    }
}