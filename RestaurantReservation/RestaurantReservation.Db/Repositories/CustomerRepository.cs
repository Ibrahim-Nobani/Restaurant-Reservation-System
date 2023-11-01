using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using RestaurantReservation.ServicesInterfaces;

namespace RestaurantReservation.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly RestaurantReservationDbContext _restaurantReservationDbContext;

        public CustomerRepository(RestaurantReservationDbContext dbContext)
        {
            _restaurantReservationDbContext = dbContext;
        }

        public void Add(Customer customer)
        {
            _restaurantReservationDbContext.Add(customer);
            _restaurantReservationDbContext.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            _restaurantReservationDbContext.Remove(customer);
            _restaurantReservationDbContext.SaveChanges();
        }

        public IEnumerable<Customer> FindCustomerByPartySize(int partySize)
        {
            var partySizeParameter = new SqlParameter("@PartySize", partySize);

            var query = "EXEC sp_FindCustomersByPartySize @PartySize";
            var customers = _restaurantReservationDbContext.Set<Customer>().FromSqlRaw(query, partySizeParameter);

            return customers;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _restaurantReservationDbContext.Customers.ToList();
        }

        public Customer GetById(int customerId)
        {
            return _restaurantReservationDbContext.Customers.Find(customerId);
        }

        public void Update(Customer customer)
        {
            _restaurantReservationDbContext.Update(customer);
            _restaurantReservationDbContext.SaveChanges();
        }
    }
}
