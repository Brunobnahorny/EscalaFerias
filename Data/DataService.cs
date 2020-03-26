using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Escalav3.Models;

namespace Escalav3.Data
{
    public class DataService : IDataService
    {
        public DataContext _context { get; }
        public DataService(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        //Store
        public async Task<Store[]> GetAllStoresAsync(bool includeVacation = false)
        {
            IQueryable<Store> query = _context.Stores;
            if (includeVacation)
            {
                query = query.Include(a => a.Employees);
            }
            query = query.AsNoTracking().OrderBy(a => a.Id);
            return await query.ToArrayAsync();
        }

        public async Task<Store> GetStoreByIdAsync(int storeId, bool includeVacation = false)
        {
            IQueryable<Store> query = _context.Stores;
            if (includeVacation)
            {
                query = query.Include(a => a.Employees);
            }
            query = query.Where(a => a.Id == storeId);
            return await query.FirstOrDefaultAsync();
        }

        //Employee
        public async Task<Employee[]> GetAllEmployeesAsync(bool includeVacation = false)
        {
            IQueryable<Employee> query = _context.Employees;
            if (includeVacation)
            {
                query = query.Include(a => a.Vacations);
            }
            query = query.AsNoTracking().OrderBy(a => a.Id);
            return await query.ToArrayAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int employeeId, bool includeVacation = false)
        {
            IQueryable<Employee> query = _context.Employees;
            if (includeVacation)
            {
                query = query.Include(a => a.Vacations);
            }
            query = query.Where(a => a.Id == employeeId);
            return await query.FirstOrDefaultAsync();
        }

        //Vacation
        public async Task<Vacation[]> GetAllVacationsAsync()
        {
            IQueryable<Vacation> query = _context.Vacations;
            query = query.AsNoTracking().OrderBy(a => a.Id);
            return await query.ToArrayAsync();
        }

        public async Task<Vacation> GetVacationByIdAsync(int VacationId)
        {
            IQueryable<Vacation> query = _context.Vacations;
            query = query.Where(a => a.Id == VacationId);
            return await query.FirstOrDefaultAsync();
        }


    }
}