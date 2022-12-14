using BourealApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BureauApp.Models
{
    public class BureauContext
    {
        public List<UsuarioBase> Usuarios { get; set; }
        public List<Cliente> Clientes { get; set; }

        public BureauContext()
        {
            Usuarios = new List<UsuarioBase>()
            {
                new UsuarioAdm()
                {
                    Id = new Guid(),
                    Login = "Adm",
                    Senha = "root",
                    IsOwner = true,
                },
                new UsuarioConsultor()
                {
                    Id = new Guid(),
                    Login = "YuriNascimento",
                    Senha = "yn2022"
                }
            };

            Clientes = new List<Cliente>();
        }
    }
}
