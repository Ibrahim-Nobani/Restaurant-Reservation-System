using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.Services
{
    public class OrderItemService
    {
        private readonly OrderItemRepository _orderItemRepository;

        public OrderItemService(OrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public OrderItem GetorderItemById(int orderItemId)
        {
            return _orderItemRepository.GetById(orderItemId);
        }

        public IEnumerable<OrderItem> GetAllorderItems()
        {
            return _orderItemRepository.GetAll();
        }

        public void CreateorderItem(OrderItem orderItem)
        {
            _orderItemRepository.Add(orderItem);
        }

        public void UpdateorderItem(OrderItem orderItem)
        {
            _orderItemRepository.Update(orderItem);
        }

        public void DeleteorderItem(OrderItem orderItem)
        {
            _orderItemRepository.Delete(orderItem);
        }
    }
}
