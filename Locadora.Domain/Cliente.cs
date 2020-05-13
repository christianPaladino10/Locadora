using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Domain
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int PlanoId { get; set; }
        public string Nome  { get; set; }
        public Plano Plano { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataModificado { get; set; }
    }
}
