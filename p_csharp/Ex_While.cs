﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp
{
    internal class Ex_While
    {
        public static void Run()
        {
            int num = 0;
            int soma = 0;
            int count = 0;

            while (num != -1)
            {
                Console.WriteLine("Informe um numero (-1 para sair)");
                num = int.Parse(Console.ReadLine());

                if (num != -1)
                {
                    soma += num;
                    count++;

                    Console.WriteLine($"Numeros informados {count}, soma {soma}, media {soma / count}");
                }
            } 
        }

    }
}
