using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Domain
{
    public class Ator
    {
        public int AtorId { get; set; }
        public string Nome { get; set; }
        public List<StreamingAtor> StreamingAtor { get; set; }
    }
}
