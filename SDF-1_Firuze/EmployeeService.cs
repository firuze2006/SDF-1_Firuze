using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDF_1_Firuze
{
    public class EmployeeService : EmployeeServiceBase
    {
        public static List<Employee> Employees = new List<Employee>();

        public override bool AddEmployee(Employee employee)
        {
            if (FindEmployee(employee.Code) != null)
                return false;

            Employees.Add(employee);
            return true;
        }

        public override Employee FindEmployee(string code)
        {
            foreach (Employee isci in Employees)
            {
                if (isci.Code == code)
                    return isci;
            }

            return null;
        }

        public override bool AddPayment(
            string employeeCode, string title, double amount)
        {
            Employee isci = FindEmployee(employeeCode);

            if (isci == null || amount <= 0 ||
                string.IsNullOrWhiteSpace(title))
                return false;

            isci.Payments.Add(new Payment(title, amount));
            return true;
        }

        public override List<Payment> GetEmployeePayments(
            string employeeCode)
        {
            Employee isci = FindEmployee(employeeCode);

            if (isci == null)
                return null;

            return isci.Payments;
        }

        public override List<Employee> GetAllEmployees()
        {
            return Employees;
        }
    }
}