using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp
{
    internal class Ex_linq
    {
        public static void Run()
        {
            List<string> numeros = new List<string>();

            numeros.Add("1");
            numeros.Add("2");
            numeros.Add("3");
            numeros.Add("4");
            numeros.Add("5");

            var found = numeros
                .Where(num => num.Equals("5", StringComparison.OrdinalIgnoreCase))
                .SingleOrDefault();

            Console.WriteLine($"Found: {found}");

            var rnd = new Random();
            List<int> randomValues = 
                 Enumerable.Range(0, 100)
                .Select(o => rnd.Next() % 100)
                .ToList();

            Console.WriteLine($"Count:{randomValues.Count()}, Average: {randomValues.Average()}, Sum: {randomValues.Sum()}");
            Console.WriteLine($"Min: {randomValues.Min()}, Max: {randomValues.Max()}");

            var ordered = randomValues.OrderBy(o => o).ToList();
            Console.WriteLine();


        }
    }
}
