using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Domain
{
    public class Aluguel
    {
        public int AluguelId { get; set; }
        public DateTime DataInicioContratacao { get; set; }
        public DateTime DataFimContratacao { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int StreamingId { get; set; }
        public Streaming Streaming { get; set; }
    }
}
