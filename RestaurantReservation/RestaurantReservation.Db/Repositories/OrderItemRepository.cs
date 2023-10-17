using RestaurantReservation.Db.Models;
using RestaurantReservation.ServicesInterfaces;

namespace RestaurantReservation.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly RestaurantReservationDbContext _restaurantReservationDbContext;

        public OrderItemRepository(RestaurantReservationDbContext dbContext)
        {
            _restaurantReservationDbContext = dbContext;
        }

        public void Add(OrderItem orderItem)
        {
            _restaurantReservationDbContext.Add(orderItem);
            _restaurantReservationDbContext.SaveChanges();
        }

        public void Delete(OrderItem orderItem)
        {
            _restaurantReservationDbContext.Remove(orderItem);
            _restaurantReservationDbContext.SaveChanges();
        }

        public IEnumerable<OrderItem> GetAll()
        {
            return _restaurantReservationDbContext.OrderItems.ToList();
        }

        public OrderItem GetById(int orderItemId)
        {
            return _restaurantReservationDbContext.OrderItems.Find(orderItemId);
        }

        public void Update(OrderItem orderItem)
        {
            _restaurantReservationDbContext.Update(orderItem);
            _restaurantReservationDbContext.SaveChanges();
        }
    }
}