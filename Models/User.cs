using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Escalav3.Models
{
    public class User
    {
        public int UserId { get; set; }
        [DataType(DataType.Password)]
        public string UserPwd { get; set; }
        public string UserName { get; set; }
        public int StoreId { get; set; }
        public ICollection<Store> Stores { get; set; } = new List<Store>();
        public User()
        {
        }

        public User(int userId, string userName, string userPwd)
        {
            UserId = userId;
            UserPwd = userPwd;
            UserName = userName;
        }
    }
}