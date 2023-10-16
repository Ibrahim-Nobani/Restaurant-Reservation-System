using RestaurantReservation.Db.Models;

namespace RestaurantReservation.ServicesInterfaces
{
    public interface IReservationFilterService
    {
        IEnumerable<Reservation> GetReservationsByCustomer(int customerId);
    }
}