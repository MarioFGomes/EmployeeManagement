

using EmployeeManagement.Aplication.DTO;
using EmployeeManagement.Aplication.DTO.Request;
using FluentValidation;

namespace EmployeeManagement.Aplication.Validators; 
public class CompanyValidator : AbstractValidator<CompanyRequest>
{
    public CompanyValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("Id cannot be empty");
        RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Name cannot be empty");
        RuleFor(x => x.NIF).NotNull().NotEmpty().WithMessage("NIF cannot be empty");
        
    }
}

public class AddressDTOValidator: AbstractValidator<AddressDTO> 
{
    public AddressDTOValidator()
    {
        RuleFor(x => x.Street).NotEmpty().WithMessage("Street cannot be empty");
        RuleFor(x => x.State).NotEmpty().WithMessage("State cannot be empty");
        RuleFor(x => x.City).NotEmpty().WithMessage("City cannot be empty");
    }
}
