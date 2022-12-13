using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BourealApp.Models
{
    internal class Cliente
    {
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected string Cnpj { get; set; }
        protected List<string> Telefone { get; set; }
        protected List<UsuarioBase> ListaUsuarioBase { get; set; }
        protected Contrato Contrato { get; set; }
    }
}
