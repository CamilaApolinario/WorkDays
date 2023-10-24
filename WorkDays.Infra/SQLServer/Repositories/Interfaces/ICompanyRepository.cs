using WorkDays.Application.DTOs;
using WorkDays.Domain.Companies;

namespace WorkDays.Infra.SQLServer.Repositories.Interfaces
{
    public interface ICompanyRepository
    {
        Company GetById(int id);
        List<Company> GetAll();
        void Add(Company company);
        Company Update(CompanyUpdateDto company);
        bool Delete(int id);
    }
}
