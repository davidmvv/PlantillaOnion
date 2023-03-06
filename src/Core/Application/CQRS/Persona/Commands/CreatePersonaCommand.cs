using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Persona.Commands
{
    public class CreatePersonaCommand
    {
        
        //Command
        public record Command(Domain.Entities.Persona Persona):IRequest<Respuesta>;

        //Handler
        public class Handler : IRequestHandler<Command, Respuesta>
        {
            private readonly IRepositoryAsync<Domain.Entities.Persona> _repositoryAsync;
            private readonly IMapper _mapper;

            public Handler(IRepositoryAsync<Domain.Entities.Persona> repositoryAsync, IMapper mapper)
            {
                    _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }           

            public Task<Respuesta> Handle(Command request, CancellationToken cancellationToken)
            {
                if (request == null)
                {
                    throw new ArgumentNullException();
                }
                return HandleProcess(request, cancellationToken);
            }

            private async Task<Respuesta> HandleProcess(Command request, CancellationToken cancellationToken)
            {
                var persona = _mapper.Map<Domain.Entities.Persona>(request.Persona);
                
                var data = await _repositoryAsync.AddAsync(persona);

                return new Respuesta(data);
            }
        }

        //Respuesta
        public record Respuesta(Domain.Entities.Persona persona);
        
    }
}
