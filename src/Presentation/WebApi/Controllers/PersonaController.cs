using Application.CQRS.Persona.Commands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Application.CQRS.Colaborador.Commands.CreateColaboradorCommand;
using static Application.CQRS.Panelist.Commands.CreatePanelistProfileCommand;
using static Application.CQRS.Panelist.Commands.CreatePanelistSkillsCommand;
using static Application.CQRS.Persona.Commands.CreatePersonaCommand;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class PersonaController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        public PersonaController()
        {
            
        }
        
        [HttpGet("/personas")]
        public async Task<IActionResult> GetAllPersonas()
        {
            var result = "";
            return Ok(result);
        }


        [HttpPost("/CreatePersona")]
        public async Task<IActionResult> CreatePersona(Command command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }


        [HttpPost("/CreatePanelist")]
        public async Task<IActionResult> CreatePanelist(CommandPanelist command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        [HttpPost("/CreatePanelistSkills")]
        public async Task<IActionResult> CreatePanelistSkills(CommandPanelistSkills command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpPost("/CreateColaborador")]
        public async Task<IActionResult> CreateColaborador(CommandColaborador command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}
