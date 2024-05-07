using EmployeeManagement.Aplication.DTO;
using EmployeeManagement.Aplication.DTO.Request;
using EmployeeManagement.Aplication.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.CrossCutting.Validators; 
public static class ValidatorsExtensions 
{
    public static IServiceCollection AddValidators(this IServiceCollection services) 
    {
        services.AddFluentValidationAutoValidation(x => x.DisableDataAnnotationsValidation = true);
        services.AddScoped<IValidator<CompanyRequest>, CompanyValidator>();
        services.AddScoped<IValidator<AddressDTO>, AddressDTOValidator>();
        return services;
    }
}
