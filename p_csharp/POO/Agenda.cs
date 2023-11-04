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
                Console.WriteLine($"{this.Contatos.IndexOf(cont) +1} - Nome: {cont.Nome}, - Email: {cont.Email}, - Numero: {cont.Numero}");
            }
        }

        internal void RemoverContato()
        {
            // Exiba uma lista com os contatos cadastrados e pergunte o indice 
            // do contato que deve ser resolvido
          this.ListarContatos();
            Console.WriteLine("informe qual contato quer remover:");
            int indiceContato = int.Parse(Console.ReadLine() );
            if (indiceContato -1 < 0)
            {
                Console.WriteLine("Contato removido com sucesso!");
                return;
            }
            if(indiceContato -1 >= this.Contatos.Count)
            {
                Console.WriteLine("Contato Invalido");
                return;
            }
            Contatos contatoSelecionado = this.Contatos[indiceContato -1];
            this.Contatos.Remove(contatoSelecionado);

            // foreach (contato c; contatos) {{lista de contatos}}
            // pergunta o indice do contato

            //metodo para remoção em Lista
            // this.Contatos.Remove(Contatos[0]);

          
        }

    }
}
