using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_Display
{
    public class Register
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime created { get; set; }
        public string Registrationnumber { get; set; }
        public string SchoolName { get; set; }
        public Gender Gender { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
