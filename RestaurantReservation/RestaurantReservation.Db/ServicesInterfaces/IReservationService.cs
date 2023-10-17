using RestaurantReservation.Db.Models;

public interface IReservationService
{
    IEnumerable<Reservation> GetReservationsByCustomer(int customerId);
}