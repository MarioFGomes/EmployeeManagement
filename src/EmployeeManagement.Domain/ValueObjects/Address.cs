

namespace EmployeeManagement.Domain.ValueObjects; 
public record class Address 
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string? Number { get; set; }

    public Address(string street,string city,string state,string number )
    {
        Street = street;
        City = city;
        State = state;
        Number = number;
    }
}
