

using EmployeeManagement.Aplication.DTO.Request;

namespace EmployeeManagement.Aplication.Interface; 
public interface ICompanyService 
{
    Task AddAsync(CompanyRequest company);
    Task UpdateAsync(CompanyRequest company);
    Task DeleteAsync(Guid Id);
}
