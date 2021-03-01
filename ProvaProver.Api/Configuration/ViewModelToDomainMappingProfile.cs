using AutoMapper;
using ProvaProver.Api.ViewModels;
using ProvaProver.DomainModel.Entity;

namespace ProvaProver.Api.Configuration
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            var dtoConfig = AutoMapperConfig.RegisterViewModelDomainMappings();
            var mapper = dtoConfig.CreateMapper();

            //Contato
            CreateMap<ContatoViewModel, Contato>();
            //   .ConstructUsing(a => new AddContatoCommand(mapper.Map<ContatoViewModel, Contato>(a)));

            //CreateMap<ContatoViewModel, UpdateContatoCommand>()
            //  .ConstructUsing(a => new UpdateContatoCommand(mapper.Map<ContatoViewModel, Contato>(a)));

            //CreateMap<ContatoViewModel, DeleteContatoCommand>()
            //  .ConstructUsing(a => new DeleteContatoCommand(mapper.Map<ContatoViewModel, Contato>(a)));

          
        }
    }
}
