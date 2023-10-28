using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp
{
    internal class Ex_Notas
    {
        public static void Run()
        {
            Console.WriteLine("Quantos alunos tem na sala?");
            int totalAlunos = int.Parse(Console.ReadLine());

            string[] alunos = new string[totalAlunos];
            float[] notas = new float[totalAlunos];

            for(int i = 0; i < totalAlunos; i++)
            {
                Console.WriteLine($"Informe o nome do aluno: (N{i + 1} ): ");
                alunos[i] = Console.ReadLine();

                Console.WriteLine($"Informe a nota do aluno:");
                notas[i] = int.Parse(Console.ReadLine());             
            }
            for (int i = 0; i < totalAlunos; i++)
            {
                Console.WriteLine($"{i + 1} - {alunos[i]}, Nota: {notas[i]} ");
            }
        }
    }
}
