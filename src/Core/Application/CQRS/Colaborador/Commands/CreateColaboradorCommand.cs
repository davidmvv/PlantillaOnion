using Application.Interfaces;
using AutoMapper;
using MediatR;
using Domian.Entities;


namespace Application.CQRS.Colaborador.Commands
{
    public class CreateColaboradorCommand
    {
        //Command
        public record CommandColaborador(Domian.Entities.Colaborador Colaborador) : IRequest<Respuesta>;

        //Handler
        public class Handler : IRequestHandler<CommandColaborador, Respuesta>
        {
            private readonly IRepositoryAsync<Domian.Entities.Colaborador> _repositoryAsync;
            private readonly IMapper _mapper;

            public Handler(IRepositoryAsync<Domian.Entities.Colaborador> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public Task<Respuesta> Handle(CommandColaborador request, CancellationToken cancellationToken)
            {
                if (request == null)
                {
                    throw new ArgumentNullException();
                }
                return HandleProcess(request, cancellationToken);
            }

            private async Task<Respuesta> HandleProcess(CommandColaborador request, CancellationToken cancellationToken)
            {
                var persona = _mapper.Map<Domian.Entities.Colaborador> (request.Colaborador);

                var data = await _repositoryAsync.AddAsync(persona);

                return new Respuesta(data);
            }
        }


        //Respuesta
        public record Respuesta(Domian.Entities.Colaborador Colaborador);
    }
}
