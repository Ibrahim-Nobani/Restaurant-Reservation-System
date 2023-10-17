using RestaurantReservation.Db.Models;
using RestaurantReservation.ServicesInterfaces;

namespace RestaurantReservation.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly RestaurantReservationDbContext _restaurantReservationDbContext;

        public ReservationRepository(RestaurantReservationDbContext dbContext)
        {
            _restaurantReservationDbContext = dbContext;
        }

        public void Add(Reservation reservation)
        {
            _restaurantReservationDbContext.Add(reservation);
            _restaurantReservationDbContext.SaveChanges();
        }

        public void Delete(Reservation reservation)
        {
            _restaurantReservationDbContext.Remove(reservation);
            _restaurantReservationDbContext.SaveChanges();
        }

        public IEnumerable<Reservation> GetAll()
        {
            return _restaurantReservationDbContext.Reservations.ToList();
        }

        public Reservation GetById(int reservationId)
        {
            return _restaurantReservationDbContext.Reservations.Find(reservationId);
        }

        public void Update(Reservation reservation)
        {
            _restaurantReservationDbContext.Update(reservation);
            _restaurantReservationDbContext.SaveChanges();
        }
    }
}