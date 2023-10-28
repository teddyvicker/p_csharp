using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp
{
    internal class Ex_for
    {
        public static void Run()
        {
            Console.WriteLine("Qual tabuada voce quer? ");
            int numero = int.Parse(Console.ReadLine());
            int somaTotal = 0;
            for (int i = 1; i <=10 ; i++)
            {
                Console.WriteLine($" - {numero} x {i} = {numero*i}");
                somaTotal += numero * i;
            }
            {
                Console.WriteLine($"a Soma total de todos os itens é: {somaTotal}");
            }
        }        
    }
}
