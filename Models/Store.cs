using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escalav3.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        [ForeignKey("User")]


        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public Store()
        {
        }

        public Store(int storeId, string name, string location, User user)
        {
            StoreId = storeId;
            Name = name;
            Location = location;
            User = user;
        }
    }
}