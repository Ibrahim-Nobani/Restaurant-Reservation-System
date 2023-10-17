using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly RestaurantReservationDbContext _restaurantReservationDbContext;

        public MenuItemRepository(RestaurantReservationDbContext dbContext)
        {
            _restaurantReservationDbContext = dbContext;
        }

        public void Add(MenuItem menuItem)
        {
            _restaurantReservationDbContext.Add(menuItem);
            _restaurantReservationDbContext.SaveChanges();
        }

        public void Delete(MenuItem menuItem)
        {
            _restaurantReservationDbContext.Remove(menuItem);
            _restaurantReservationDbContext.SaveChanges();
        }

        public IEnumerable<MenuItem> GetAll()
        {
            return _restaurantReservationDbContext.MenuItems.ToList();
        }

        public MenuItem GetById(int menuItemId)
        {
            return _restaurantReservationDbContext.MenuItems.Find(menuItemId);
        }

        public void Update(MenuItem menuItem)
        {
            _restaurantReservationDbContext.Update(menuItem);
            _restaurantReservationDbContext.SaveChanges();
        }
    }
}