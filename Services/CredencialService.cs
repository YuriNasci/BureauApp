using BourealApp.Models;
using BureauApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BureauApp.Services
{
    internal class CredencialService
    {
        private BureauContext _context;
        public CredencialService(BureauContext context)
        {
            _context = context;
        }

        public UsuarioBase? Logar(string login, string senha)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Login == login && u.Senha == senha);
        }
    }
}
