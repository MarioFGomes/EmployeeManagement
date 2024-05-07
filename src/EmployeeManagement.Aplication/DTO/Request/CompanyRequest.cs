using EmployeeManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Aplication.DTO.Request; 
public class CompanyRequest 
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string? Phone { get; set; }
    public string NIF { get; set; }
    public IEnumerable<AddressDTO> address { get; set; }

    public CompanyRequest(Guid id, string name, string description, string phone, IEnumerable<AddressDTO> _address, string nif)
    {
        Id=id;
        Name=name;
        Description=description;
        Phone=phone;
        address = _address;
        NIF = nif;
    }
}
