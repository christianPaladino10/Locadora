using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Domain
{
    public class StreamingAtor
    {
        public int AtorId { get; set; }
        public Ator Ator { get; set; }
        public int StreamingId { get; set; }
        public Streaming Streaming { get; set; }
    }
}
