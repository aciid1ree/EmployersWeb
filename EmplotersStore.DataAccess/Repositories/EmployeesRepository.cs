using Dapper;
using EmployeesStore.App.Models;
using EmployeesStore.Core.Abstractions;
using EmployersWeb.Api;

namespace EmployeesStore.DataAccess.Repositories;
public class EmployeesRepository : IEmployeesRepository
{
    private readonly DapperDbContext _context;
    public EmployeesRepository(DapperDbContext context)
    {
        _context = context;
    }
    public async Task<List<Employee>> GetAll()
    {
        string query = "SELECT * FROM Employees";
        using var connect = _context.CreateConnection();
        var answerlist = await connect.QueryAsync<Employee>(query);
        return answerlist.ToList();
    }
}
