using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;
using RestaurantReservation.ServicesInterfaces;

namespace RestaurantReservation.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetCustomerById(int customerId)
        {
            return _customerRepository.GetById(customerId);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        public void CreateCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.Update(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            _customerRepository.Delete(customer);
        }

        public IEnumerable<Customer> FindCustomerByPartySize(int partySize)
        {
            return _customerRepository.FindCustomerByPartySize(partySize);
        }
    }
}