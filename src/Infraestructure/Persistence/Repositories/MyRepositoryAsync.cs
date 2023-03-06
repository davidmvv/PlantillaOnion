using Application.Interfaces;
using Ardalis.Specification.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class MyRepositoryAsync<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly PersonaDBContext _dbContext;
        public MyRepositoryAsync(PersonaDBContext context) : base(context)
        {
            this._dbContext = context;
        }
    }
}
