namespace CRM.DataAccess
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Data access repository.
    /// </summary>
    public class CRMRepository : IDisposable, ICRMRepository
    {
        private CRMContext _cRMContext;
        private bool _disposed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="CRMRepository"/> class.
        /// </summary>
        /// <param name="cRMContext">Database Context.</param>
        public CRMRepository(CRMContext cRMContext)
        {
            _cRMContext = cRMContext;
        }

        /// <summary>
        /// Get all table as IQueryable.
        /// </summary>
        /// <typeparam name="TEntity">Database Entity.</typeparam>
        /// <returns>IQueryable from table.</returns>
        public IQueryable<TEntity> GetTEntity<TEntity>()
          where TEntity : class
        {
            DbSet<TEntity> dbEntitySet = _cRMContext.Set<TEntity>();
            return dbEntitySet;
        }

        /// <summary>
        /// Get Tabledata by Id.
        /// </summary>
        /// <typeparam name="TEntity">Database Entity.</typeparam>
        /// <param name="entityID">ID from the tupel.</param>
        /// <returns>Tabledata from TEntity.</returns>
        public TEntity? GetEntityByID<TEntity>(int entityID)
          where TEntity : class
        {
            DbSet<TEntity> dbEntitySet = _cRMContext.Set<TEntity>();
            return dbEntitySet.Find(entityID);
        }

        /// <summary>
        /// Insert new Entry.
        /// </summary>
        /// <typeparam name="TEntity">Database Entity.</typeparam>
        /// <param name="entity">New table tupel.</param>
        public void InsertEntity<TEntity>(TEntity entity)
          where TEntity : class
        {
            DbSet<TEntity> dbEntitySet = _cRMContext.Set<TEntity>();
            dbEntitySet.Add(entity);
        }

        /// <summary>
        /// Delete entry by ID.
        /// </summary>
        /// <typeparam name="TEntity">Database Entity.</typeparam>
        /// <param name="entityId">ID from the tupel.</param>
        public void Delete<TEntity>(int entityId)
          where TEntity : class
        {
            DbSet<TEntity> dbEntitySet = _cRMContext.Set<TEntity>();
            TEntity? entity = dbEntitySet.Find(entityId);

            if (entity != null)
            {
                dbEntitySet.Remove(entity);
            }
        }

        /// <summary>
        /// Update table Tupel.
        /// </summary>
        /// <typeparam name="TEntity">Database Entity.</typeparam>
        /// <param name="entity">New table tupel.</param>
        public void Update<TEntity>(TEntity entity)
          where TEntity : class
        {
            DbSet<TEntity> dbEntitySet = _cRMContext.Set<TEntity>();
        }

        /// <summary>
        /// Save changes.
        /// </summary>
        /// <returns>Number of entries.</returns>
        public int SaveChanges()
        {
            return _cRMContext.SaveChanges();
        }

        /// <summary>
        /// Save changes async.
        /// </summary>
        /// <returns>Number of entries.</returns>
        public async Task<int> SaveChangesAsync()
        {
            return await _cRMContext.SaveChangesAsync();
        }

        /// <summary>
        /// Dispose the class.
        /// </summary>
        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            this.Dispose(true);
        }

        /// <summary>
        /// Dispose the class.
        /// </summary>
        private void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // _cRMContext.SaveChanges();
                _cRMContext.Dispose();
            }

            GC.SuppressFinalize(this);
            _disposed = true;
        }
    }
}
