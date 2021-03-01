using System.Threading.Tasks;

namespace ProvaProver.DomainModel.Interfaces.UoW
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
    }
}
