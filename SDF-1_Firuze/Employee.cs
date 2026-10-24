using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDF_1_Firuze
{
    public class Employee
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Payment> Payments { get; set; }
            = new List<Payment>();

        public Employee(string code, string firstName,
            string lastName, int age)
        {
            Code = code;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
