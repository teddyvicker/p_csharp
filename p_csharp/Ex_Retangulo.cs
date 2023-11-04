using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp
{
    internal class Ex_Retangulo
    {
        public static void Run()
        {
            Random random = new Random();
            List<Point> retangulos = Enumerable.Range(0, 100)
                .Select(o =>  new Point(random.Next() % 600, random.Next() % 2000))
                .ToList();
            Point minRect = retangulos.OrderBy(rect => rect.X * rect.Y).First();
            Point maxRect = retangulos.OrderByDescending(rect => rect.X * rect.Y).First();

            Console.WriteLine($"Count: {retangulos.Count}");
            Console.WriteLine($"Area Média: {retangulos.Average(rect => rect.X * rect.Y)}");
            Console.WriteLine($"Menor: (X:{minRect.X}, Y:{minRect.Y})");
            Console.WriteLine($"Maior: (X:{maxRect.X}, Y:{maxRect.Y})");
        }
    }
}
