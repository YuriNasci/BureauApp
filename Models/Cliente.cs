using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BourealApp.Models
{
    internal class Cliente
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public List<string> Telefones { get; set; }
        public List<UsuarioBase> ListaUsuarioBase { get; set; }
        public Contrato Contrato { get; set; }
    }
}
