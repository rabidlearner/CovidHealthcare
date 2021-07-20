using AutoMapper;
namespace CovidHealthcare.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            Mapper.CreateMap<Models.Customer, CovidHealthcareApi.DTO.Customer>();
            Mapper.CreateMap<CovidHealthcareApi.DTO.Customer, CovidHealthcare.Models.Customer>();
            Mapper.CreateMap<CovidHealthcare.Models.Hospital, CovidHealthcareApi.DTO.Hospital>();
            Mapper.CreateMap<CovidHealthcareApi.DTO.Hospital, CovidHealthcare.Models.Hospital>();
            Mapper.CreateMap<CovidHealthcare.Models.User, CovidHealthcareApi.DTO.User>();
            Mapper.CreateMap<CovidHealthcareApi.DTO.User, CovidHealthcare.Models.User>();
            Mapper.CreateMap<CovidHealthcare.Models.UserRole, CovidHealthcareApi.DTO.UserRole>();
            Mapper.CreateMap<CovidHealthcareApi.DTO.UserRole, CovidHealthcare.Models.UserRole>();

            Mapper.CreateMap<CovidHealthcareApi.Repository.Entity.UserRole, CovidHealthcareApi.DTO.UserRole>();
            Mapper.CreateMap<CovidHealthcareApi.DTO.UserRole, CovidHealthcareApi.Repository.Entity.UserRole>();
            Mapper.CreateMap<CovidHealthcareApi.Repository.Entity.User, CovidHealthcareApi.DTO.User>();
            Mapper.CreateMap<CovidHealthcareApi.DTO.User, CovidHealthcareApi.Repository.Entity.User>();
            Mapper.CreateMap<CovidHealthcareApi.Repository.Entity.Customer, CovidHealthcareApi.DTO.Customer>();
            Mapper.CreateMap<CovidHealthcareApi.DTO.Customer, CovidHealthcareApi.Repository.Entity.Customer>();
            Mapper.CreateMap<CovidHealthcareApi.Repository.Entity.Hospital, CovidHealthcareApi.DTO.Hospital>();
            Mapper.CreateMap<CovidHealthcareApi.DTO.Hospital, CovidHealthcareApi.Repository.Entity.Hospital>();
            Mapper.CreateMap<CovidHealthcareApi.Repository.Entity.Doctor, CovidHealthcareApi.DTO.Doctor>();
            Mapper.CreateMap<CovidHealthcareApi.DTO.Doctor, CovidHealthcareApi.Repository.Entity.Doctor>();

            Mapper.CreateMap<ViewModel.UserRole, Models.UserRole>();
            Mapper.CreateMap<Models.UserRole, ViewModel.UserRole>();
            Mapper.CreateMap<ViewModel.User, Models.User>();
            Mapper.CreateMap<Models.User, ViewModel.User>();
            Mapper.CreateMap<ViewModel.Customer, Models.Customer>();
            Mapper.CreateMap<Models.Customer, ViewModel.Customer>();
            Mapper.CreateMap<ViewModel.Hospital, Models.Hospital>();
            Mapper.CreateMap<Models.Hospital, ViewModel.Hospital>();
            Mapper.CreateMap<ViewModel.Doctor, Models.Doctor>();
            Mapper.CreateMap<Models.Doctor, ViewModel.Doctor>();

        }
    }
}