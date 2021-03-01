using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvaProver.Api.ViewModels;
using ProvaProver.DomainModel.Entity;
using ProvaProver.DomainModel.Entity;
using ProvaProver.DomainModel.Interfaces.Services;

namespace ProvaProver.Api.Controllers
{
    [ApiVersion("1.0")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase

    {
        private readonly IContatoService _ContatoService;

        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public ContatoController(IContatoService ContatoService, IMapper mapper, ILogger<ContatoController> logger)
        {
            _ContatoService = ContatoService;
            _mapper = mapper;
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<ContatoViewModel>> GetAll()
        {
            _logger.LogInformation("Executing api/Contato -> GetAll");

            return _mapper.Map<IEnumerable<ContatoViewModel>>(await _ContatoService.GetAllContatos());
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ContatoViewModel>> Get(Guid id)
        {
            _logger.LogInformation("Executing api/Contato -> Get");

            var Contato = _mapper.Map<ContatoViewModel>(await _ContatoService.GetContato(id));

            if (Contato == null) return NotFound();

            return Contato;
        }

        [HttpPost]
        public async Task<ActionResult<ContatoViewModel>> Post(ContatoViewModel ContatoViewModel)
        {
            _logger.LogInformation("Executing api/Contato -> Post");

            if (!ModelState.IsValid) return BadRequest();
            return Ok(_ContatoService.AddContato(_mapper.Map<ContatoViewModel, Contato>(ContatoViewModel)));
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ContatoViewModel>> Put(Guid id, ContatoViewModel ContatoViewModel)
        {
            _logger.LogInformation("Executing api/Contato -> Put");

            if (id != ContatoViewModel.Id)
            {
                return BadRequest("The id entered is not the same as the one passed in the query.");
            }

            if (!ModelState.IsValid) return BadRequest();

            return Ok(_ContatoService.UpdateContato(_mapper.Map<ContatoViewModel, Contato>(ContatoViewModel)));
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ContatoViewModel>> Delete(Guid id)
        {
            _logger.LogInformation("Executing api/Contato -> Delete");

            var Contato = _mapper.Map<ContatoViewModel>(await _ContatoService.GetContato(id));

            return Ok(_ContatoService.DeleteContato(id));
        }

    }
}
