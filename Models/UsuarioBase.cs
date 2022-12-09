using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BourealApp.Models
{
    internal class UsuarioBase
    {
        protected Guid Id { get; set; }
        protected string Login { get; set; }
        protected string Senha { get; set; }
        protected Guid CodigoCliente { get; set; }
        
        public string Logar(string login, string senha)
        {
            return string.Empty;
        }
    }
}
