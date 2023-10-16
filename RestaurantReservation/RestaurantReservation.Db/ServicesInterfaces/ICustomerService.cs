using RestaurantReservation.Db.Models;

namespace RestaurantReservation.ServicesInterfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> FindCustomerByPartySize(int partySize);
    }
}