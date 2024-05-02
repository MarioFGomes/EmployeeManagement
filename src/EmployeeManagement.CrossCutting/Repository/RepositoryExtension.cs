

using EmployeeManagement.Domain.Interfaces;
using EmployeeManagement.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.CrossCutting.Repository; 
public static class RepositoryExtension 
{
    public static IServiceCollection AddRepositories(this IServiceCollection services) 
    {
        services.AddScoped<ICompanyRepository, CompanyRepository>();

        return services;
    }
}
