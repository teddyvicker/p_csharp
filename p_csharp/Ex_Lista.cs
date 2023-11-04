using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp
{
    internal class Ex_Lista
    {
        public static void Run()
        { 
            LinkedList<string> meses = new LinkedList<string>();

            meses.AddLast("Dezembro");
            meses.AddFirst("Janeiro");
            var dezembro = meses.Find("Dezembro");
            meses.AddBefore(dezembro, "janeiro");
            meses.AddAfter(dezembro, "janeiro");
            
            var node = new LinkedListNode<string>("Janeiro");
            meses.AddLast(node);

            foreach (string mes in meses)
            {
                Console.WriteLine(mes);
            }
        }
    }
}
