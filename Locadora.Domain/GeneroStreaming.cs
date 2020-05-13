using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Domain
{
    public class GeneroStreaming
    {
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
        public int StreamingId { get; set; }
        public Streaming Streaming { get; set; }
    }
}
