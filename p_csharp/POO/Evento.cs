using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_csharp.POO
{
    public class Evento
    {
        public string Nome { get; set; }
        public List<Contatos> Participantes { get; set; }

        public Evento()
        {
            this.Participantes = new List<Contatos>();
        }
    }
}
