using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Domain
{
    public class Plano
    {
        public int PlanoId { get; set; }
        public string Tipo { get; set; }
        public int QtdAluguelSimultaneo { get; set; }

    }
}
