using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp
{
    internal class Calculadora
    {
        public static void Run()
            {
                Console.WriteLine("CALCULADORA ");
                Console.WriteLine(" 1 - Soma ");
                Console.WriteLine(" 2 - Produto ");
                Console.WriteLine(" 3 - Subtração ");
                Console.WriteLine(" 4 - Divisão ");

                string op = Console.ReadLine().ToLower();

                Console.WriteLine("Informe o Valor de A");
                int ValorA = int.Parse(Console.ReadLine());


                Console.WriteLine("Informe o Valor de B");
                int ValorB = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case "1":
                        Console.WriteLine($"A Soma de {ValorA} e {ValorB} é {ValorA + ValorB}");
                        break;
                case "2":
                    Console.WriteLine($"A Produto de {ValorA} e {ValorB} é {ValorA % ValorB}");
                    break;
                case "3":
                    Console.WriteLine($"A Subtração de {ValorA} e {ValorB} é {ValorA - ValorB}");
                    break;
                case "4":
                    Console.WriteLine($"A Divisao de {ValorA} e {ValorB} é {ValorA / ValorB}");
                    break;
                default:
                        Console.WriteLine("Nao Entendi");
                        break;
                }

            }
        }
    }
