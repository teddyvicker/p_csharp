using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp
{
    internal class Ex_Fila
    {
        public static void Run()
        {
            Queue <string>  minhaFila = new Queue <string> ();

            minhaFila.Enqueue("UEA");
            minhaFila.Enqueue("VIC");
            minhaFila.Enqueue("CASA");
            minhaFila.Enqueue("TESTE");
            minhaFila.Enqueue("SOS");

            Console.WriteLine($"Quantidade : {minhaFila.Count}");
            Console.WriteLine("Valores: ");

            while (minhaFila.Count > 0)
                Console.WriteLine(minhaFila.Dequeue());

        }

    }
}
