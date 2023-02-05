using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repository;

namespace EmployeeManagementAPI.Services
{
    public class EmployeeService
    {
        public IEmployee _EmployeeRepository;

        public EmployeeService (IEmployee employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }

        public string SaveEmployee (Employee employee)
        {
            return _EmployeeRepository.SaveEmployee (employee);
        }

        public string DeleteEmployee(int id)
        {
            return _EmployeeRepository.DeleteEmployee (id);
        }

        public string UpdateEmployee(Employee employee)
        {
            return _EmployeeRepository.UpdateEmployee (employee);
        }

        public Employee GetEmployee(int id)
        {
            return _EmployeeRepository.GetEmployee (id);
        }

        public List<Employee> GetAllEmployee()
        {
            return _EmployeeRepository.GetAllEmployee ();
        }
    }
}
