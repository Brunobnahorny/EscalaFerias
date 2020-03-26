using System;

namespace Escalav3.Models
{
    public class Vacation
    {
        public int Id { get; set; }
        public DateTime InitDate { get; set; }
        public int VacationDays { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        public Vacation()
        {
        }

        public Vacation(int vacationId, DateTime initDate, int vacationDays, Employee employee)
        {
            Id = vacationId;
            InitDate = initDate;
            VacationDays = vacationDays;
            Employee = employee;
        }
    }
}