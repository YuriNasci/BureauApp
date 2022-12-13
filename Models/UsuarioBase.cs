using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BourealApp.Models
{
    public class UsuarioBase
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Guid CodigoCliente { get; set; }
        
        public string Logar(string login, string senha)
        {
            return string.Empty;
        }
    }
}
