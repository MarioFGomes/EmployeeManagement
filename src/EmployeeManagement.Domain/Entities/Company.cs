using EmployeeManagement.Domain.Enums;
using EmployeeManagement.Domain.ValueObjects;
using MongoDB.Bson.Serialization.Attributes;

namespace EmployeeManagement.Domain.Entities; 

public class Company 
{
    [BsonId]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string? Phone { get; set; }
    public IEnumerable<Address> address { get; set; }
    public string NIF { get; set; }
    public StateCompany State {  get; set; }

    public Company(Guid id,string name,string description,string phone, IEnumerable<Address> _address,string nif)
    {
        Id = id;
        Name = name;
        Description = description;
        Phone = phone;
        address= _address;
        NIF = nif;
        State = StateCompany.Ative;
    }

}
