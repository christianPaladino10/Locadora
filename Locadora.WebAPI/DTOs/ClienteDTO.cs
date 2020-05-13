using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.DTOs
{
    public class ClienteDTO
    {
        public string Nome { get; set; }
        public PlanoDTO Plano { get; set; }
    }
}
