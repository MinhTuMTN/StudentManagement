using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccessLayer.Models
{
    public class UserLogin
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public bool IsActived { get; set; }
    }
}
