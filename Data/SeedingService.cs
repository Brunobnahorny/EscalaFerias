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

            

            Employee e1 = new Employee("Bob Brown", new DateTime(1998, 4, 21).Date, 1000.0, s1);
            Employee e2 = new Employee("Maria Green", new DateTime(1979, 12, 31).Date, 3500.0, s1);
            Employee e3 = new Employee("Alex Grey", new DateTime(1988, 1, 15).Date, 2200.0, s1);
            Employee e4 = new Employee("Martha Red", new DateTime(1993, 11, 30).Date, 3000.0, s1);
            Employee e5 = new Employee("Donald Blue", new DateTime(2000, 1, 9).Date, 4000.0, s1);
            Employee e6 = new Employee("Alex Pink", new DateTime(1997, 3, 4).Date, 3000.0, s1);

            Employee e7 = new Employee("Shura PuraBura", new DateTime(1998, 4, 21).Date, 3000.0, s2);
            Employee e8 = new Employee("Maria Yellow", new DateTime(1979, 12, 31).Date, 1500.0, s2);
            Employee e9 = new Employee("Alexandre Greyte", new DateTime(1988, 1, 15).Date, 2100.0, s2);
            Employee e10 = new Employee("Martha Carpha", new DateTime(1993, 11, 30).Date, 3000.0, s2);
            Employee e11 = new Employee("Donald Trump", new DateTime(2000, 1, 9).Date, 1600.0, s2);
            Employee e12 = new Employee("Bolso What", new DateTime(1997, 3, 4).Date, 3000.0, s2);

            Vacation v1 = new Vacation(new DateTime(2018, 09, 25).Date, 30, e1);
            Vacation v2 = new Vacation(new DateTime(2018, 09, 4).Date, 30, e5);
            Vacation v3 = new Vacation(new DateTime(2018, 09, 13).Date, 30, e4);
            Vacation v4 = new Vacation(new DateTime(2018, 09, 1).Date, 30, e1);
            Vacation v5 = new Vacation(new DateTime(2018, 09, 21).Date, 30, e3);
            Vacation v6 = new Vacation(new DateTime(2018, 09, 15).Date, 30, e1);
            Vacation v7 = new Vacation(new DateTime(2018, 09, 28).Date, 30, e2);
            Vacation v8 = new Vacation(new DateTime(2018, 09, 11).Date, 30, e4);
            Vacation v9 = new Vacation(new DateTime(2018, 09, 14).Date, 30, e6);
            Vacation v10 = new Vacation(new DateTime(2018, 09, 7).Date, 30, e6);
            Vacation v11 = new Vacation(new DateTime(2018, 09, 13).Date, 30, e2);
            Vacation v12 = new Vacation(new DateTime(2018, 09, 25).Date, 30, e3);
            Vacation v13 = new Vacation(new DateTime(2018, 09, 29).Date, 30, e4);
            Vacation v14 = new Vacation(new DateTime(2018, 09, 4).Date, 30, e5);
            Vacation v15 = new Vacation(new DateTime(2018, 09, 12).Date, 30, e1);
            Vacation v16 = new Vacation(new DateTime(2018, 10, 5).Date, 30, e4);
            Vacation v17 = new Vacation(new DateTime(2018, 10, 1).Date, 30, e1);
            Vacation v18 = new Vacation(new DateTime(2018, 10, 24).Date, 30, e3);
            Vacation v19 = new Vacation(new DateTime(2018, 10, 22).Date, 30, e5);
            Vacation v20 = new Vacation(new DateTime(2018, 10, 15).Date, 30, e6);
            Vacation v21 = new Vacation(new DateTime(2018, 10, 17).Date, 30, e2);
            Vacation v22 = new Vacation(new DateTime(2018, 10, 24).Date, 30, e4);
            Vacation v23 = new Vacation(new DateTime(2018, 10, 19).Date, 30, e2);
            Vacation v24 = new Vacation(new DateTime(2018, 10, 12).Date, 30, e5);
            Vacation v25 = new Vacation(new DateTime(2018, 10, 31).Date, 30, e3);
            Vacation v26 = new Vacation(new DateTime(2018, 10, 6).Date, 30, e4);
            Vacation v27 = new Vacation(new DateTime(2018, 10, 13).Date, 30, e1);
            Vacation v28 = new Vacation(new DateTime(2018, 10, 7).Date, 30, e3);
            Vacation v29 = new Vacation(new DateTime(2018, 10, 23).Date, 30, e5);
            Vacation v30 = new Vacation(new DateTime(2018, 10, 12).Date, 30, e2);

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