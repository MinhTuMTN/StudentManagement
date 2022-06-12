using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccessLayer.Models
{
    public class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
