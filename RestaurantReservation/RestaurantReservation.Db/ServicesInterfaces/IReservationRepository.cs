using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.ServicesInterfaces
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        
    }
}