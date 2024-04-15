using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using RestaurantReservation.ServicesInterfaces;

namespace RestaurantReservation.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly RestaurantReservationDbContext _restaurantReservationDbContext;

        public OrderRepository(RestaurantReservationDbContext dbContext)
        {
            _restaurantReservationDbContext = dbContext;
        }

        public void Add(Order order)
        {
            _restaurantReservationDbContext.Add(order);
            _restaurantReservationDbContext.SaveChanges();
        }

        public void Delete(Order order)
        {
            _restaurantReservationDbContext.Remove(order);
            _restaurantReservationDbContext.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return _restaurantReservationDbContext.Orders.ToList();
        }

        public Order GetById(int orderId)
        {
            return _restaurantReservationDbContext.Orders.Find(orderId);
        }

        public void Update(Order order)
        {
            _restaurantReservationDbContext.Update(order);
            _restaurantReservationDbContext.SaveChanges();
        }
        public IEnumerable<Order> ListOrdersAndMenuItems(int reservationId)
        {
            return _restaurantReservationDbContext.Orders
                .Where(o => o.ReservationId == reservationId)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.MenuItem)
                .ToList();
        }

        public IEnumerable<Order> GetEmployeeOrders(int employeeId)
        {
            return _restaurantReservationDbContext.Orders
                .Where(o => o.EmployeeId == employeeId);
        }
    }
}