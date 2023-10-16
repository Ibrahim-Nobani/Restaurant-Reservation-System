using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;
using RestaurantReservation.Exceptions;
namespace RestaurantReservation.Services
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order GetOrderById(int orderId)
        {
            return _orderRepository.GetById(orderId);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public void CreateOrder(Order order)
        {
            _orderRepository.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            _orderRepository.Update(order);
        }

        public void DeleteOrder(Order order)
        {
            _orderRepository.Delete(order);
        }

        public IEnumerable<Order> ListOrdersAndMenuItems(int reservationId)
        {
            return _orderRepository.ListOrdersAndMenuItems(reservationId);
        }

        public decimal CalculateAverageOrderAmount(int employeeId)
        {
            var ordersByEmployee = _orderRepository.GetEmployeeOrders(employeeId);

            if (!ordersByEmployee.Any())
            {
                throw new OrdersNotFoundException("No orders were found for this employee!");
            }

            decimal totalAmountSum = ordersByEmployee.Sum(o => o.TotalAmount);
            int ordersCount = ordersByEmployee.Count();
            return totalAmountSum / ordersCount;
        }
    }
}
