using Application.Interfaces;
using AutoMapper;
using MediatR;
using Domian.Entities;

namespace Application.CQRS.Panelist.Commands
{
    public class CreatePanelistProfileCommand
    {
        //Command
        public record CommandPanelist(PanelistProfile Panelist) : IRequest<Respuesta>;

        //Handler
        public class Handler : IRequestHandler<CommandPanelist, Respuesta>
        {
            private readonly IRepositoryAsync<PanelistProfile> _repositoryAsync;
            private readonly IMapper _mapper;

            public Handler(IRepositoryAsync<PanelistProfile> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public Task<Respuesta> Handle(CommandPanelist request, CancellationToken cancellationToken)
            {
                if (request == null)
                {
                    throw new ArgumentNullException();
                }
                return HandleProcess(request, cancellationToken);
            }

            private async Task<Respuesta> HandleProcess(CommandPanelist request, CancellationToken cancellationToken)
            {
                var persona = _mapper.Map<PanelistProfile>(request.Panelist);

                var data = await _repositoryAsync.AddAsync(persona);

                return new Respuesta(data);
            }
        }


        //Respuesta
        public record Respuesta(PanelistProfile Panelist);
    }
}
