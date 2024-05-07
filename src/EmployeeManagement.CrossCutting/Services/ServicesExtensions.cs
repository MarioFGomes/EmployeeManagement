using EmployeeManagement.Aplication.Interface;
using EmployeeManagement.Aplication.Services;
using Microsoft.Extensions.DependencyInjection;


namespace EmployeeManagement.CrossCutting.Services; 
public static class ServicesExtensions 
{
    public static IServiceCollection AddServices(this IServiceCollection services) {
        services.AddScoped<ICompanyService, CompanyService>();

        return services;
    }
}
