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

            Clientes = new List<Cliente>()
            {
                new Cliente()
                {
                    Nome = "Indústrias Acme",
                    Cnpj = "55.537.921/0001-80",
                    Telefones = new List<string>{"4002-8922"}
                },
                new Cliente()
                {
                    Nome = "Organizações Tabajara",
                    Cnpj = "28.952.259/0001-51",
                    Telefones = new List<string>{"0500-2022-007"}
                }
            };
        }
    }
}
