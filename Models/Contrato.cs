using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BourealApp.Models
{
    public class Contrato
    {
        protected Guid Id { get; set; }
        protected decimal Valor { get; set; }
        protected DateTime DataVigencia { get; set; }
        protected PlanoTarifacao PlanoTarifacao { get; set; }
    }
}
