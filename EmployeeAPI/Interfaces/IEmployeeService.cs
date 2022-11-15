using EmployeeAPI.Models;

namespace EmployeeAPI.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee GetById(int Id);
        List<Employee> Add(Employee employee);
        List<Employee> Delete(int id);
        List<Employee> Update(Employee employee);
        bool ValidateEmail(string email);
        int GetEmployeeCount();
    }
}
