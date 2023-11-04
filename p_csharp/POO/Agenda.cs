using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp.POO
{
    internal class Agenda
    {
        public bool cont;

        public List<Contatos> Contatos { get; set; }
        public Agenda() 
        { 
            Contatos = new List<Contatos>();
        
        }
        public void AdicionarContato()
        {
            string GetString(string pergunta)
            {
                Console.WriteLine(pergunta);
                return Console.ReadLine();
            }
            Contatos novoContato = new Contatos()
            {
                Nome = GetString("---Informe o Nome: "),
                Email = GetString("---Informe o Email: "),
                Numero = GetString("---Informe o Numero: ")
            };

            while(this.Contatos.Any(cont => cont.Numero == novoContato.Numero))

            {
                novoContato.Numero = GetString("---Contato já Existe!---");
            }
            
            this.Contatos.Add(novoContato);
                     
        }
        public void ListarContatos()
        {
            Console.WriteLine();
            foreach (var cont in this.Contatos)
            {
                Console.WriteLine($"Nome: {cont.Nome}, Email: {cont.Email}, Numero: {cont.Numero}");
            }
        }
    }
}
