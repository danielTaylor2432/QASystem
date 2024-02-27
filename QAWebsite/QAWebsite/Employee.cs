using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAWebsite
{
    public class Employee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public EmployeeType Type { get; set; }

        public Employee(string username, string password, EmployeeType type)
        {
            Username = username;
            Password = password;
            Type = type;
        }
    }

    public enum EmployeeType
    {
        Manager,
        Developer,
        HR
    }
}
