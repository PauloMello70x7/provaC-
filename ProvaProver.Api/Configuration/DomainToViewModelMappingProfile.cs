using AutoMapper;
using ProvaProver.Api.ViewModels;
using ProvaProver.DomainModel.Entity;

namespace ProvaProver.Api.Configuration
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Contato, ContatoViewModel>().ReverseMap();
        }
    }
}
