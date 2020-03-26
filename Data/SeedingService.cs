using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escalav3.Models;

namespace Escalav3.Data
{
    public class SeedingService
    {
        private DataContext _context;

        public SeedingService(DataContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Employees.Any() ||
                _context.Vacations.Any())
            {
                return; // DB has been seeded
            }
            
            User u1 = new User(1, "Brunobnahorny", "123456");
            User u2 = new User(2, "Eduardaoreano", "654321");


            Store s1 = new Store(1, "St Monica", "Av. Madre Benvenuta", u1);
            Store s2 = new Store(2, "Trindade", "Lauro Linhares, 123", u1);
            Store s3 = new Store(3, "Agronomica", "Av. Delminda Silveira, 234", u2);

            

            Employee e1 = new Employee(1, "Bob Brown", new DateTime(1998, 4, 21), 1000.0, s1);
            Employee e2 = new Employee(2, "Maria Green", new DateTime(1979, 12, 31), 3500.0, s1);
            Employee e3 = new Employee(3, "Alex Grey", new DateTime(1988, 1, 15), 2200.0, s1);
            Employee e4 = new Employee(4, "Martha Red", new DateTime(1993, 11, 30), 3000.0, s1);
            Employee e5 = new Employee(5, "Donald Blue", new DateTime(2000, 1, 9), 4000.0, s1);
            Employee e6 = new Employee(6, "Alex Pink", new DateTime(1997, 3, 4), 3000.0, s1);

            Employee e7 = new Employee(7, "Shura PuraBura", new DateTime(1998, 4, 21), 3000.0, s2);
            Employee e8 = new Employee(8, "Maria Yellow", new DateTime(1979, 12, 31), 1500.0, s2);
            Employee e9 = new Employee(9, "Alexandre Greyte", new DateTime(1988, 1, 15), 2100.0, s2);
            Employee e10 = new Employee(10, "Martha Carpha", new DateTime(1993, 11, 30), 3000.0, s2);
            Employee e11 = new Employee(11, "Donald Trump", new DateTime(2000, 1, 9), 1600.0, s2);
            Employee e12 = new Employee(12, "Bolso What", new DateTime(1997, 3, 4), 3000.0, s2);

            Vacation v1 = new Vacation(1, new DateTime(2018, 09, 25), 30, e1);
            Vacation v2 = new Vacation(2, new DateTime(2018, 09, 4), 30, e5);
            Vacation v3 = new Vacation(3, new DateTime(2018, 09, 13), 30, e4);
            Vacation v4 = new Vacation(4, new DateTime(2018, 09, 1), 30, e1);
            Vacation v5 = new Vacation(5, new DateTime(2018, 09, 21), 30, e3);
            Vacation v6 = new Vacation(6, new DateTime(2018, 09, 15), 30, e1);
            Vacation v7 = new Vacation(7, new DateTime(2018, 09, 28), 30, e2);
            Vacation v8 = new Vacation(8, new DateTime(2018, 09, 11), 30, e4);
            Vacation v9 = new Vacation(9, new DateTime(2018, 09, 14), 30, e6);
            Vacation v10 = new Vacation(10, new DateTime(2018, 09, 7), 30, e6);
            Vacation v11 = new Vacation(11, new DateTime(2018, 09, 13), 30, e2);
            Vacation v12 = new Vacation(12, new DateTime(2018, 09, 25), 30, e3);
            Vacation v13 = new Vacation(13, new DateTime(2018, 09, 29), 30, e4);
            Vacation v14 = new Vacation(14, new DateTime(2018, 09, 4), 30, e5);
            Vacation v15 = new Vacation(15, new DateTime(2018, 09, 12), 30, e1);
            Vacation v16 = new Vacation(16, new DateTime(2018, 10, 5), 30, e4);
            Vacation v17 = new Vacation(17, new DateTime(2018, 10, 1), 30, e1);
            Vacation v18 = new Vacation(18, new DateTime(2018, 10, 24), 30, e3);
            Vacation v19 = new Vacation(19, new DateTime(2018, 10, 22), 30, e5);
            Vacation v20 = new Vacation(20, new DateTime(2018, 10, 15), 30, e6);
            Vacation v21 = new Vacation(21, new DateTime(2018, 10, 17), 30, e2);
            Vacation v22 = new Vacation(22, new DateTime(2018, 10, 24), 30, e4);
            Vacation v23 = new Vacation(23, new DateTime(2018, 10, 19), 30, e2);
            Vacation v24 = new Vacation(24, new DateTime(2018, 10, 12), 30, e5);
            Vacation v25 = new Vacation(25, new DateTime(2018, 10, 31), 30, e3);
            Vacation v26 = new Vacation(26, new DateTime(2018, 10, 6), 30, e4);
            Vacation v27 = new Vacation(27, new DateTime(2018, 10, 13), 30, e1);
            Vacation v28 = new Vacation(28, new DateTime(2018, 10, 7), 30, e3);
            Vacation v29 = new Vacation(29, new DateTime(2018, 10, 23), 30, e5);
            Vacation v30 = new Vacation(30, new DateTime(2018, 10, 12), 30, e2);

            /*
            _context.Users.AddRange(u1, u2);

            _context.Stores.AddRange(s1, s2, s3);

            */

            _context.Employees.AddRange(e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12);

            _context.Vacations.AddRange(
                v1, v2, v3, v4, v5, v6, v7, v8, v9, v10,
                v11, v12, v13, v14, v15, v16, v17, v18, v19, v20,
                v21, v22, v23, v24, v25, v26, v27, v28, v29, v30
            );

            _context.SaveChanges();
        }
    }
}