

using EmployeeManagement.Aplication.DTO;
using EmployeeManagement.Aplication.DTO.Request;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.ValueObjects;

namespace EmployeeManagement.Aplication.Mappers; 
public static class CompanyMapper 
{
    public static Company ToCompanyDomain(this CompanyRequest company) 
    {
        var addressCompany = company.address.Select(x => x.ToAddressDomain());

        return new Company(company.Id, company.Name, company.Description, company.Phone, addressCompany, company.NIF);
    }

    public static Address ToAddressDomain(this AddressDTO addressDTO) 
    {
        return new Address(addressDTO.Street, addressDTO.City, addressDTO.State, addressDTO.Number);
    }
}
