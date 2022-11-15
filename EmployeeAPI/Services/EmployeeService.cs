using EmployeeAPI.Interfaces;
using EmployeeAPI.Models;
using System.Text.RegularExpressions;

namespace EmployeeAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _employeeList = new List<Employee>();

        public EmployeeService()
        {
            for(int i = 1; i <=5; i++)
            {
                _employeeList.Add(new Employee
                {
                    Id= i,
                    Address1 = ("Address1_" + i),
                    Address2 = ("Address2_" + i),
                    DateOfBirth = DateTime.Now.AddYears(30-i),
                    FirstName = ("FirstName_" + i),
                    LastName = ("LAstName_" + i),
                    City = ("City_" + i),
                    State = "CA",
                    ZipCode = ("00000" + i),
                    Email = "Email_" + i + "@email.net"
                });
            }
        }

        public List<Employee> Add(Employee employee)
        {
            _employeeList.Add(employee);
            return _employeeList;
        }

        public List<Employee> Delete(int id)
        {
            return _employeeList.Where(e => e.Id != id).ToList();
        }

        public List<Employee> GetAll()
        {
            return _employeeList;
        }

        public Employee GetById(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public List<Employee> Update(Employee employee)
        {
            var empToUpdate = _employeeList.Where(_e => _e.Id == employee.Id).FirstOrDefault();
            empToUpdate = employee;
            return _employeeList;
        }

        public bool ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentException();
            return Regex.IsMatch(email, @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$");
        }

        public int GetEmployeeCount()
        {
            return _employeeList.Count;
        }
    }
}
