using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Aplication.DTO; 
public class AddressDTO 
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string? Number { get; set; }

    public AddressDTO(string street, string city, string state, string number) {
        Street = street;
        City = city;
        State = state;
        Number = number;
    }
}
