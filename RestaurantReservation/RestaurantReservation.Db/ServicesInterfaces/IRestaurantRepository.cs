using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.ServicesInterfaces
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        decimal CalculateTotalRevenueByRestaurant(int restaurantId);
    }
}