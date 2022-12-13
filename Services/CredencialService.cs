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
        BureauContext context = new BureauContext();

        public UsuarioBase? Logar(string login, string senha)
        {
            return context.Usuarios.FirstOrDefault(u => u.Login == login && u.Senha == senha);
        }
    }
}
