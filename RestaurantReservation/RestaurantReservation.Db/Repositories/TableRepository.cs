using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Repositories
{
    public class TableRepository : IRepository<Table>
    {
        private readonly RestaurantReservationDbContext _restaurantReservationDbContext;

        public TableRepository(RestaurantReservationDbContext dbContext)
        {
            _restaurantReservationDbContext = dbContext;
        }

        public void Add(Table table)
        {
            _restaurantReservationDbContext.Add(table);
            _restaurantReservationDbContext.SaveChanges();
        }

        public void Delete(Table table)
        {
            _restaurantReservationDbContext.Remove(table);
            _restaurantReservationDbContext.SaveChanges();
        }

        public IEnumerable<Table> GetAll()
        {
            return _restaurantReservationDbContext.Tables.ToList();
        }

        public Table GetById(int tableId)
        {
            return _restaurantReservationDbContext.Tables.Find(tableId);
        }

        public void Update(Table table)
        {
            _restaurantReservationDbContext.Update(table);
            _restaurantReservationDbContext.SaveChanges();
        }
    }
}
