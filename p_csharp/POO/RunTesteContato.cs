using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp.POO
{
    internal class RunTesteContato
    {
        public static Contatos CriarContato()
        {
            Console.WriteLine("--NOVO CONTATO--");
            string GetString(string pergunta)
            {
                Console.WriteLine(pergunta);
                return Console.ReadLine();
            }

            return new Contatos()
            {
                Nome = GetString("Informe o Nome: "),
                Email = GetString("Informe o Email: "),
                Numero = GetString("Informe o Numero: ")
            };
        }
        public static void Run()
        {
            List<Contatos> contatos = new List<Contatos>();

            contatos.Add(CriarContato());
            foreach (var cont in contatos)
            {
                Console.WriteLine($"Nome: {cont.Nome}, Email: {cont.Email}, Numero: {cont.Numero}");
            }
        
        }
        public static void ExecutarAgenda()
        {
            Agenda agenda = new Agenda();
            ConsoleKeyInfo GetKey(string pergunta)
            {
                Console.WriteLine(pergunta);
                return Console.ReadKey();
            }
            while(GetKey("Adicionar contato ou ESC para Sair").Key != ConsoleKey.Escape)
            {
                agenda.AdicionarContato();
            }
            agenda.ListarContatos();
        }
    }
}
