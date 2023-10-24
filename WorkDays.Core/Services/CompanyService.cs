using AutoMapper;
using WorkDays.Application.DTOs;
using WorkDays.Application.DTOs.CompanyDto;
using WorkDays.Core.Services.Interfaces;
using WorkDays.Domain.Companies;
using WorkDays.Infra.SQLServer.Repositories;
using WorkDays.Infra.SQLServer.Repositories.Interfaces;

namespace WorkDays.Core.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public List<Company> GetCompany()
        {
            return _companyRepository.GetAll().ToList();
        }

        public Company PostCompany(CompanyDto company)
        {
            var companyMapping = _mapper.Map<Company>(company);
            _companyRepository.Add(companyMapping);
            return companyMapping;
        }

        public Company PutCompany(CompanyUpdateDto company)
        {
            var companyNew = _companyRepository.Update(company);
            return companyNew;
        }

        public bool DeleteCompany(int id)
        {
           return _companyRepository.Delete(id);
        }
    }
}
