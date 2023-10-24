using WorkDays.Application.DTOs;
using WorkDays.Application.DTOs.CompanyDto;
using WorkDays.Domain.Companies;

namespace WorkDays.Core.Services.Interfaces
{
    public interface ICompanyService
    {
        Company PostCompany(CompanyDto company);
        List<Company> GetCompany();

        Company PutCompany(CompanyUpdateDto company);
        bool DeleteCompany(int id);
    }
}
