using BourealApp.Models;
using BureauApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BureauApp.Services
{
    public class ClienteService
    {
        BureauContext _context { get; set; }
        public ClienteService(BureauContext bureauContext)
        {
            _context = bureauContext;
        }

        public List<Cliente> GetList()
        {
            return _context.Clientes;
        }

        internal void Excluir(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
        }
    }
}
