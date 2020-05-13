using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Domain
{
    public class Streaming
    {
        public int StreamingId { get; set; }
        public string Sinopse { get; set; }
        public string Titulo { get; set; }
        public int ClassificacaoIndicativa { get; set; }
        public string ImagemURL { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataModificado { get; set; }
        public int TipoStreamingId { get; set; }
        public TipoStreaming TipoStreaming { get; set; }
        public List<StreamingAtor> StreamingAtor { get; set; }
        public List<GeneroStreaming> GeneroStreaming { get; set; }

    }
}
