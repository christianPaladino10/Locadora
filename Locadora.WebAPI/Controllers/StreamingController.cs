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
    public class StreamingController : ControllerBase
    {
        private readonly ILocadoraRepository _repository;
        private readonly IMapper _mapper;

        public StreamingController(ILocadoraRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var listStreaming = await _repository.GetAllStreamingAsync(true, true);
            var results = _mapper.Map<IEnumerable<StreamingDTO>>(listStreaming);
            return Ok(results);
        }
    }
}