using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;
using RestaurantReservation.ServicesInterfaces;

namespace RestaurantReservation.Services
{
    public class MenuItemService
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public MenuItemService(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public MenuItem GetMenuItemById(int menuItemId)
        {
            return _menuItemRepository.GetById(menuItemId);
        }

        public IEnumerable<MenuItem> GetAllMenuItems()
        {
            return _menuItemRepository.GetAll();
        }

        public void CreateMenuItem(MenuItem menuItem)
        {
            _menuItemRepository.Add(menuItem);
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            _menuItemRepository.Update(menuItem);
        }

        public void DeleteMenuItem(MenuItem menuItem)
        {
            _menuItemRepository.Delete(menuItem);
        }
    }
}
