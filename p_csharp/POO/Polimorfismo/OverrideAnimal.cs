using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp.POO.Polimorfismo
{
    class ProgramPolimorfismo
    {
        public static void Run()
        {
            Cachorro animal = new Cachorro();
            animal.EmitirSom();
        }
    }

    class Animal
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("Som genérico");
        }
    }

    class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Latido");
        }
    }
}
