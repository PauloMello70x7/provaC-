using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProvaProver.DomainModel.Entity;

namespace ProvaProver.DomainModel.Interfaces.Repositories
{
    public interface IContatoRepository : IRepository<Contato>
    {
        Task<IEnumerable<Contato>> GetContatos();

        Task<Contato> GetContato(Guid id);
    }
}
