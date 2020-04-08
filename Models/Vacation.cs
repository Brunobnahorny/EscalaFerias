using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escalav3.Models
{
    public class Vacation
    {
        [Key]
        public int VacationId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime InitDate { get; set; }
        public int VacationDays { get; set; }

        public Employee Employee { get; set; }

        public Vacation()
        {
        }

        public Vacation(DateTime initDate, int vacationDays, Employee employee)
        {
            InitDate = initDate;
            VacationDays = vacationDays;
            Employee = employee;
        }
    }
}