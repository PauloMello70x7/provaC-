using System.Threading.Tasks;
using ProvaProver.DomainModel.Interfaces.UoW;
using ProvaProver.Infra.Context;

namespace ProvaProver.Infra.UoW
{
    public class EntityFrameworkUnitOfWork : IUnitOfWork
    {
        private readonly ProvaProverContext _context;

        public EntityFrameworkUnitOfWork(ProvaProverContext context)
        {
            this._context = context;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

      
    }
}
