using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp
{
    internal class TesteQuestao9
    {

        public static void Run()
        {
            {
                Console.WriteLine("Digite um numero");
                int numeroLados = int.Parse(Console.ReadLine());

                string resultado = IdentificarPoligono(numeroLados);

                Console.WriteLine(resultado);
            }

            static string IdentificarPoligono(int numeroLados)
            {
                switch (numeroLados)
                {
                    case 3:
                        return "triângulo";
                    case 4:
                        return "quadrilátero";
                    case 5:
                        return "pentágono";
                    case 6:
                        return "hexágono";
                    case 7:
                        return "heptágono";
                    case 8:
                        return "octógono";
                    case 9:
                        return "eneágono";
                    case 10:
                        return "decágono";
                    default:
                        return "polígono não identificado";
                }
            }
        }

    }
}




            
        