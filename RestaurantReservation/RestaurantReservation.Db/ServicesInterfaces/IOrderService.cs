using RestaurantReservation.Db.Models;

namespace RestaurantReservation.ServicesInterfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> ListOrdersAndMenuItems(int reservationId);
        IEnumerable<Order> GetEmployeeOrders(int employeeId);
    }
}