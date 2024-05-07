using EmployeeManagement.Aplication.DTO.Request;
using EmployeeManagement.Aplication.Interface;
using EmployeeManagement.Aplication.Mappers;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Interfaces;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace EmployeeManagement.Aplication.Services;
public class CompanyService : ICompanyService 
{
    private readonly ICompanyRepository _companyRepository;

    public CompanyService(ICompanyRepository companyRepository)
    {
        _companyRepository = companyRepository;
    }
    public async Task AddAsync(CompanyRequest company) 
    {
        var CompanyDomain = company.ToCompanyDomain();

        await _companyRepository.AddOneAsync(CompanyDomain);
    }

    public async Task DeleteAsync(Guid Id) 
    {
        var filter = new FilterDefinitionBuilder<Company>()
            .Where(x => x.Id ==Id);

        await _companyRepository.DeleteAsync(_=>filter.Inject());
    }

    public async Task UpdateAsync(CompanyRequest company) 
    {
        var filter = new FilterDefinitionBuilder<Company>()
            .Where(x => x.Id == company.Id);

        var CompanyDomain = company.ToCompanyDomain();

        await _companyRepository.ReplaceOneAsync(_ => filter.Inject(), CompanyDomain);
    }
}
