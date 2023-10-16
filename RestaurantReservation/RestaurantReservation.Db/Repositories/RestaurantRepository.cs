using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using RestaurantReservation.ServicesInterfaces;

namespace RestaurantReservation.Repositories
{
    public class RestaurantRepository : IRepository<Restaurant>, IRestaurantService
    {
        private readonly RestaurantReservationDbContext _restaurantReservationDbContext;

        public RestaurantRepository(RestaurantReservationDbContext dbContext)
        {
            _restaurantReservationDbContext = dbContext;
        }

        public void Add(Restaurant restaurant)
        {
            _restaurantReservationDbContext.Add(restaurant);
            _restaurantReservationDbContext.SaveChanges();
        }

        public void Delete(Restaurant restaurant)
        {
            _restaurantReservationDbContext.Remove(restaurant);
            _restaurantReservationDbContext.SaveChanges();
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurantReservationDbContext.Restaurants.ToList();
        }

        public Restaurant GetById(int restaurantId)
        {
            return _restaurantReservationDbContext.Restaurants.Find(restaurantId);
        }

        public void Update(Restaurant restaurant)
        {
            _restaurantReservationDbContext.Update(restaurant);
            _restaurantReservationDbContext.SaveChanges();
        }

        public decimal CalculateTotalRevenueByRestaurant(int restaurantId)
        {
            var totalRevenue = _restaurantReservationDbContext.Database.SqlQueryRaw<decimal>(
            "SELECT dbo.CalculateTotalRevenueByRestaurant(@restaurantId) as Value",
            new SqlParameter("@restaurantId", restaurantId));

            return totalRevenue.SingleOrDefault();
        }
    }
}