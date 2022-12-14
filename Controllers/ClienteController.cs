using BourealApp.Models;
using BureauApp.Models;
using BureauApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BureauApp.Controllers
{
    internal class ClienteController
    {
        public BureauContext _context { get; set; }
        public ClienteService _clienteService { get; set; }

        public ClienteController(BureauContext context)
        {
            _context = context;
            _clienteService = new ClienteService(context);
        }

        public void Criar()
        {
            //Nome, CNPJ, Telefones.
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            while (nome == null)
            {
                Console.WriteLine("Campo Nome é obrigatório.");
                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();
            }

            Console.WriteLine("CNPJ: ");
            var cnpj = Console.ReadLine();

            while (cnpj == null)
            {
                Console.WriteLine("Campo CNPJ é obrigatório.");
                Console.WriteLine("CNPJ: ");
            }

            Console.WriteLine("Telefone 1: ");
            var telefone1 = Console.ReadLine();

            Console.WriteLine("Telefone 2: ");
            var telefone2 = Console.ReadLine();

            while(telefone1 == null && telefone2 == null)
            {
                Console.WriteLine("Informe ao menos 1 telefone.");
                Console.WriteLine("Telefone: ");
                telefone1 = Console.ReadLine();
            }

            Cliente cliente = new Cliente()
            {
                Nome = nome,
                Cnpj = cnpj,
                Telefones = new List<string>()
            };

            if (telefone1 != null) cliente.Telefones.Add(telefone1);
            if (telefone2 != null) cliente.Telefones.Add(telefone2);

            _context.Clientes.Add(cliente);
            Console.WriteLine("Cliente cadastrado com sucesso.");
        }
        
        public void Excluir()
        {
            Console.WriteLine("Digite o número do cliente a ser excluído:");
            var clientes = _clienteService.GetList().OrderBy(c => c.Nome).ToArray();
            int i = 1;
            foreach(var cliente in clientes)
            {
                Console.WriteLine(i++ + " - " + cliente.Nome);
            }

            var opcaoReaded = Console.ReadLine();
            while(opcaoReaded == null || int.Parse(opcaoReaded ?? "") >= i)
            {
                Console.WriteLine("Opção Inválida");
            }

            int opcaoInt = int.Parse(opcaoReaded ?? "") - 1;

            _clienteService.Excluir(clientes[opcaoInt]);
            Console.WriteLine("Cliente excluído.");
        }
    }
}
