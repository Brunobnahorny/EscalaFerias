using System.Collections.Generic;
using System.Threading.Tasks;
using Escalav3.Models;

namespace Escalav3.Data
{
    public interface IDataService
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Stores
        Task<Store[]> GetAllStoresAsync(bool includeVacations);
        Task<Store> GetStoreByIdAsync(int StoreId, bool includeVacations);

        //Employee
        Task<Employee[]> GetAllEmployeesAsync(bool includeVacations);
        Task<Employee> GetEmployeeByIdAsync(int EmployeeId, bool includeVacations);

        //Vacation
        Task<Vacation[]> GetAllVacationsAsync();
        Task<Vacation> GetVacationByIdAsync(int VacationId);
        
    }
}