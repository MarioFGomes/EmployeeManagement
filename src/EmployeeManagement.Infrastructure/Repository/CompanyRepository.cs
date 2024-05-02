using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Interfaces;
using MongoDB.Driver;


namespace EmployeeManagement.Infrastructure.Repository;
public class CompanyRepository : BaseRepository<Company>, ICompanyRepository {
    public CompanyRepository(IMongoDatabase mongoDb, string collectionName) : base(mongoDb, "Company"){}
}
