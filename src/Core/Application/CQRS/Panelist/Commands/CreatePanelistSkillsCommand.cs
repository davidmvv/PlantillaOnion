using Application.Interfaces;
using AutoMapper;
using MediatR;
using Domian.Entities;


namespace Application.CQRS.Panelist.Commands
{
    public class CreatePanelistSkillsCommand
    {
        public record CommandPanelistSkills(PanelistSkills Panelist) : IRequest<Respuesta>;

        //Handler
        public class Handler : IRequestHandler<CommandPanelistSkills, Respuesta>
        {
            private readonly IRepositoryAsync<PanelistSkills> _repositoryAsync;
            private readonly IMapper _mapper;

            public Handler(IRepositoryAsync<PanelistSkills> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public Task<Respuesta> Handle(CommandPanelistSkills request, CancellationToken cancellationToken)
            {
                if (request == null)
                {
                    throw new ArgumentNullException();
                }
                return HandleProcess(request, cancellationToken);
            }

            private async Task<Respuesta> HandleProcess(CommandPanelistSkills request, CancellationToken cancellationToken)
            {
                var persona = _mapper.Map<PanelistSkills>(request.Panelist);

                var data = await _repositoryAsync.AddAsync(persona);

                return new Respuesta(data);
            }
        }


        //Respuesta
        public record Respuesta(PanelistSkills Panelist);
    }
}
