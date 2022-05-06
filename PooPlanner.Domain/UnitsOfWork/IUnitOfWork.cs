using PooPlanner.Domain.Entities;
using PooPlanner.Domain.Repository;

namespace PooPlanner.Domain.UnitsOfWork
{
    public interface IUnitOfWork
    {
        GenericRepository<Dish> DishRepository { get; }
        GenericRepository<Medicine> MedicineRepository { get; }
        GenericRepository<Stool> StoolRepository { get; }

        void Dispose();
        void Save();
    }
}