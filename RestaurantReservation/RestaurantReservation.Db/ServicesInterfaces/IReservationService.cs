using RestaurantReservation.Db.Models;

namespace RestaurantReservation.ServicesInterfaces
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetReservationsByCustomer(int customerId);
    }
}