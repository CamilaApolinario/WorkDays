using AutoMapper;
using WorkDays.Application.DTOs.CompanyDto;
using WorkDays.Domain.Companies;

namespace WorkDays.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CompanyDto, Company>();
        }
    }
}
