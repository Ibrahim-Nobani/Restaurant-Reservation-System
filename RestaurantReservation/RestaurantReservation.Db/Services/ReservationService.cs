using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;
using RestaurantReservation.ServicesInterfaces;

namespace RestaurantReservation.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public Reservation GetReservationById(int reservationId)
        {
            return _reservationRepository.GetById(reservationId);
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationRepository.GetAll();
        }

        public void CreateReservation(Reservation reservation)
        {
            _reservationRepository.Add(reservation);
        }

        public void UpdateReservation(Reservation reservation)
        {
            _reservationRepository.Update(reservation);
        }

        public void DeleteReservation(Reservation reservation)
        {
            _reservationRepository.Delete(reservation);
        }

        public IEnumerable<Reservation> GetReservationsByCustomer(int customerId)
        {
            return _reservationRepository.GetAll().Where(reservation => reservation.CustomerId == customerId);
        }
    }
}
