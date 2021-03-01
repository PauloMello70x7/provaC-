using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProvaProver.DomainModel.Entity;
using ProvaProver.DomainModel.Interfaces.Repositories;
using ProvaProver.DomainModel.Interfaces.Services;
using ProvaProver.DomainModel.Interfaces.UoW;

namespace ProvaProver.DomainService
{
    public class ContatoService : IContatoService
    {
        private IContatoRepository _ContatoRepository;
        private IUnitOfWork _unitOfWork;


        public ContatoService(IContatoRepository ContatoRepository, IUnitOfWork unitOfWork)
        {
            _ContatoRepository = ContatoRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddContato(Contato Contato)
        {
            _ContatoRepository.Create(Contato);
            await _unitOfWork.CommitAsync();
        }
        public async Task UpdateContato(Contato Contato)
        {
            _ContatoRepository.Update(Contato);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteContato(Guid id)
        {
            _ContatoRepository.Delete(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Contato>> GetAllContatos()
        {
            return await _ContatoRepository.ReadAll();
        }


        public async Task<Contato> GetContato(Guid id)
        {
            return await _ContatoRepository.Read(id);
        }



    }
}
