using EmployeesStore.App.Models;
using System.Web.Http.OData;
namespace EmployeesStore.Core.Abstractions;

public interface IEmployeesRepository
{
    Task<List<Employee>> GetAll();
    Task<int> Create(Employee employee);
    Task RemoveId(int id);
    Task<List<Employee>> GetByNameCompany(string name);
    Task<List<Employee>> GetByNameDepartment(string name);
    Task<List<Employee>> PatchbyId(int id, Employee updateEmployee);
}
