using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.Services
{
    public class TableService
    {
        private readonly ITableRepository _tableRepository;

        public TableService(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public Table GetTableById(int tableId)
        {
            return _tableRepository.GetById(tableId);
        }

        public IEnumerable<Table> GetAllTables()
        {
            return _tableRepository.GetAll();
        }

        public void CreateTable(Table table)
        {
            _tableRepository.Add(table);
        }

        public void UpdateTable(Table table)
        {
            _tableRepository.Update(table);
        }

        public void DeleteTable(Table table)
        {
            _tableRepository.Delete(table);
        }
    }
}
