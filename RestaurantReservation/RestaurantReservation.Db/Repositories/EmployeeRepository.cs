using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly RestaurantReservationDbContext _restaurantReservationDbContext;

        public EmployeeRepository(RestaurantReservationDbContext dbContext)
        {
            _restaurantReservationDbContext = dbContext;
        }

        public void Add(Employee employee)
        {
            _restaurantReservationDbContext.Add(employee);
            _restaurantReservationDbContext.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            _restaurantReservationDbContext.Remove(employee);
            _restaurantReservationDbContext.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _restaurantReservationDbContext.Employees.ToList();
        }

        public Employee GetById(int employeeId)
        {
            return _restaurantReservationDbContext.Employees.Find(employeeId);
        }

        public void Update(Employee employee)
        {
            _restaurantReservationDbContext.Update(employee);
            _restaurantReservationDbContext.SaveChanges();
        }
    }
}
