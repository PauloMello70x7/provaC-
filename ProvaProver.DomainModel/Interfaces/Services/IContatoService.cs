using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProvaProver.DomainModel.Entity;

namespace ProvaProver.DomainModel.Interfaces.Services
{
    public interface IContatoService
    {  
        Task AddContato(Contato Contato);
        Task UpdateContato(Contato Contato);
        Task DeleteContato(Guid id);
        Task<Contato> GetContato(Guid id);
        Task<IEnumerable<Contato>> GetAllContatos();
    }
}
