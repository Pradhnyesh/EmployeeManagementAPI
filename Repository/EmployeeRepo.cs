using EmployeeManagementAPI.Data;
using EmployeeManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.Repository
{
    public class EmployeeRepo : IEmployee
    {
        private DataContext _DataContext;
        public EmployeeRepo(DataContext EmployeeDb)
        {
            _DataContext = EmployeeDb;
        }
        public string DeleteEmployee(int Id)
        {
            string msg = "";
            Employee deleteEmployee = _DataContext.Employees.Find(Id);
            if (deleteEmployee != null)
            {
                _DataContext.Employees.Remove(deleteEmployee);
                _DataContext.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> employees = _DataContext.Employees.ToList();
            return employees;
        }

        public Employee GetEmployee(int Id)
        {
            Employee employee = _DataContext.Employees.Find(Id);
            return employee;
        }

        public string SaveEmployee(Employee employee)
        {
            _DataContext.Employees.Add(employee);
            _DataContext.SaveChanges();
            return "Saved";
        }

        public string UpdateEmployee(Employee employee)
        {
            _DataContext.Entry(employee).State = EntityState.Modified;
            _DataContext.SaveChanges();
            return "Updated";
        }
    }
}
