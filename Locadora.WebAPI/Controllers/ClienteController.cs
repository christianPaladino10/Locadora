using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Locadora.DTOs;
using Locadora.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ILocadoraRepository _repository;
        private readonly IMapper _mapper;

        public ClienteController(ILocadoraRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var cliente = await _repository.GetClienteAsyncById(id);
            var result = _mapper.Map<ClienteDTO>(cliente);
            return Ok(result);
        }

    }
}