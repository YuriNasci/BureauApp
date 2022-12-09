using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BourealApp.Models
{
    internal class Fornecedor
    {
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected string DescricaoInstituicao { get; set; }
    }
}