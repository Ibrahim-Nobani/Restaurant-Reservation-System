using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.ServicesInterfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> FindCustomerByPartySize(int partySize);
    }
}