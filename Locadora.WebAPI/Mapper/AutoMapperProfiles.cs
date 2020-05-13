using AutoMapper;
using Locadora.Domain;
using Locadora.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Streaming, StreamingDTO>()
                .ForMember(dto => dto.Ator, opt => {
                    opt.MapFrom(domain => domain.StreamingAtor.Select(x => x.Ator).ToList());
                })
                .ForMember(dto => dto.Genero, opt => {
                    opt.MapFrom(domain => domain.GeneroStreaming.Select(x => x.Genero).ToList());
                });

            CreateMap<Ator, AtorDTO>();
            CreateMap<Genero, GeneroDTO>();
            CreateMap<TipoStreaming, TipoStreamingDTO>();
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<Plano, PlanoDTO>();
        }
    }
}
