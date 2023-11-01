using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;
using RestaurantReservation.ServicesInterfaces;

namespace RestaurantReservation.Services
{
    public class OrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public OrderItem GetOrderItemById(int orderItemId)
        {
            return _orderItemRepository.GetById(orderItemId);
        }

        public IEnumerable<OrderItem> GetAllOrderItems()
        {
            return _orderItemRepository.GetAll();
        }

        public void CreateOrderItem(OrderItem orderItem)
        {
            _orderItemRepository.Add(orderItem);
        }

        public void UpdateOrderItem(OrderItem orderItem)
        {
            _orderItemRepository.Update(orderItem);
        }

        public void DeleteOrderItem(OrderItem orderItem)
        {
            _orderItemRepository.Delete(orderItem);
        }
    }
}
