using EmployeeManagement.Aplication.Validators;
using EmployeeManagement.CrossCutting.Repository;
using EmployeeManagement.CrossCutting.Services;
using EmployeeManagement.CrossCutting.Validators;

namespace EmployeeManagement.API; 
public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddRepositories();
        builder.Services.AddValidators();
        builder.Services.AddControllers(options=>options.Filters.Add(typeof (ActionValidationAttribute)));
        builder.Services.AddServices();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment()) {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.Run();
    }
}