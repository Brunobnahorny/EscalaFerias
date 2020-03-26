using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Escalav3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateAdmission { get; set; }
        [DataType(DataType.Currency)]
        public double BaseSalary { get; set; }
        public Store Store { get; set; }
        public int StoreId { get; set; }
        public ICollection<Vacation> Vacations { get; set; } = new List<Vacation>();

        public Employee()
        {
        }

        public Employee(int employeeId, string name, DateTime dateAdmission, double baseSalary, Store store)
        {
            Id = employeeId;
            Name = name;
            DateAdmission = dateAdmission;
            BaseSalary = baseSalary;
            Store = store;
        }
    }
}