using System.ComponentModel.Design;
using WorkDays.Application.DTOs;
using WorkDays.Domain.Companies;
using WorkDays.Infra.SQLServer.Repositories.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WorkDays.Infra.SQLServer.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly WorkDaysDbContext _context;

        public CompanyRepository(WorkDaysDbContext context)
        {
            _context = context;
        }

        public void Add(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var company = GetById(id);
            if (company != null)
            {
                _context.Companies.Remove(company);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Company> GetAll()
        {
            return _context.Companies.ToList();
        }

        public Company GetById(int id)
        {
            return _context.Companies
                .FirstOrDefault(x => x.Id == id);
        }

        public Company Update(CompanyUpdateDto company)
        {
            var companyOld = GetById(company.CompanyId);
            companyOld.Name = company.NewNameCompany;
            _context.Companies.Update(companyOld);
            _context.SaveChanges();
            return companyOld;
        }
    }
}
