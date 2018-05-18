using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Logic.Models
{
    public class User
    {
        public int Userid { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string Confirmpassword { get; set; }
        public string Dob { get; set; }
    }
}
