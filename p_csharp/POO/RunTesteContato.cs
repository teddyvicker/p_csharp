﻿using System;
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

            int GetOpt(string pergunta)
            {
                Console.WriteLine(pergunta);
                return int.Parse(Console.ReadLine());
            }
            StringBuilder options = new StringBuilder();
            options.AppendLine("1 - Adcionar Contato ");
            options.AppendLine("2 - Listar Contato ");
            options.AppendLine("3 - Remover Contato ");
            options.AppendLine("4 - Sair ");
            options.AppendLine("Escolha uma das Opções");

            int opt = 0;
            while ((opt = GetOpt(options.ToString())) != 0)
            {
                switch (opt)
                {
                    case 1:
                        agenda.AdicionarContato();
                        break;
                    case 2:
                        agenda.ListarContatos();
                        break;
                    case 3:
                        agenda.RemoverContato();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }
        }
    }
}
