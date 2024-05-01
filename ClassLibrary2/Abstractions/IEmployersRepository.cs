using EmployersStore.App.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployersStore.Core.Abstractions
{
    public interface IEmployersRepository
    {
        Task<List<Employee>> GetAll();
    }
}
