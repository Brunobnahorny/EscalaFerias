using System.Collections.Generic;

namespace Escalav3.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public Store()
        {
        }

        public Store(int storeId, string name, string location, User user)
        {
            Id = storeId;
            Name = name;
            Location = location;
            User = user;
        }
    }
}