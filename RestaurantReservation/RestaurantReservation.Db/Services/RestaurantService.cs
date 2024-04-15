using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;
using RestaurantReservation.ServicesInterfaces;

namespace RestaurantReservation.Services
{
    public class RestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public Restaurant GetRestaurantById(int restaurantId)
        {
            return _restaurantRepository.GetById(restaurantId);
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return _restaurantRepository.GetAll();
        }

        public void CreateRestaurant(Restaurant restaurant)
        {
            _restaurantRepository.Add(restaurant);
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            _restaurantRepository.Update(restaurant);
        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            _restaurantRepository.Delete(restaurant);
        }

        public decimal CalculateTotalRevenueByRestaurant(int restaurantId)
        {
            return _restaurantRepository.CalculateTotalRevenueByRestaurant(restaurantId);
        }
    }
}
