using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Repository
{
    public interface IEmployee
    {
        public string SaveEmployee(Employee employee);
        public string UpdateEmployee(Employee employee);
        public string DeleteEmployee(int Id);
        public Employee GetEmployee(int Id);
        public List<Employee> GetAllEmployee();

    }
}
