using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.DTOs
{
    public class StreamingDTO
    {
        public int id { get; set; }
        public string Sinopse { get; set; }
        public string Titulo { get; set; }
        public int ClassificacaoIndicativa { get; set; }
        public string ImagemURL { get; set; }
        public string DataLancamento { get; set; }
        public TipoStreamingDTO TipoStreaming { get; set; }
        public List<AtorDTO> Ator { get; set; }
        public List<GeneroDTO> Genero { get; set; }
    }
}
