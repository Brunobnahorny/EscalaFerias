using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escalav3.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateAdmission { get; set; }
        [DataType(DataType.Currency)]
        public double BaseSalary { get; set; }

        [ForeignKey("Store")]
        public int StoreId { get; set; }
        public Store Store { get; set; }

        public ICollection<Vacation> Vacations { get; set; } = new List<Vacation>();

        public Employee()
        {
        }

        public Employee(string name, DateTime dateAdmission, double baseSalary, Store store)
        {
            Name = name;
            DateAdmission = dateAdmission;
            BaseSalary = baseSalary;
            Store = store;
        }
    }
}