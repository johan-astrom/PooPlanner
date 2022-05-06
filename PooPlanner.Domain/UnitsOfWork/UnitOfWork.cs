using PooPlanner.Domain.DataAccess;
using PooPlanner.Domain.Entities;
using PooPlanner.Domain.Repository;

namespace PooPlanner.Domain.UnitsOfWork
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private PooPlannerContext _context;
        private GenericRepository<Dish> _dishRepository;
        private GenericRepository<Stool> _stoolRepository;
        private GenericRepository<Medicine> _medicineRepository;
        public GenericRepository<Dish> DishRepository
        {
            get
            {
                if (this._dishRepository == null)
                {
                    this._dishRepository = new GenericRepository<Dish>(_context);
                }
                return this._dishRepository;
            }
        }
        public GenericRepository<Stool> StoolRepository
        {
            get
            {
                if (this._stoolRepository == null)
                {
                    this._stoolRepository = new GenericRepository<Stool>(_context);
                }
                return this._stoolRepository;
            }
        }
        public GenericRepository<Medicine> MedicineRepository
        {
            get
            {
                if (this._medicineRepository == null)
                {
                    this._medicineRepository = new GenericRepository<Medicine>(_context);
                }
                return this._medicineRepository;
            }
        }

        public UnitOfWork(PooPlannerContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposed)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}