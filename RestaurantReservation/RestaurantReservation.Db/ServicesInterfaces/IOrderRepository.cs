using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.ServicesInterfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> ListOrdersAndMenuItems(int reservationId);
        IEnumerable<Order> GetEmployeeOrders(int employeeId);
    }
}