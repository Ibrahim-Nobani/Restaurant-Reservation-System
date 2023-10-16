using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;
using RestaurantReservation.ServicesInterfaces;

namespace RestaurantReservation.Services
{
    public class EmployeeService : IManagerService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _employeeRepository.GetById(employeeId);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public void CreateEmployee(Employee employee)
        {
            _employeeRepository.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.Update(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeRepository.Delete(employee);
        }
        public IEnumerable<Employee> ListAllManagers()
        {
            return _employeeRepository.GetAll()
                .Where(employee => employee.Position == "Manager")
                .ToList();
        }
    }
}
