namespace CRM.DataAccess
{
    /// <summary>
    /// Contract to CRMRepository.
    /// </summary>
    public interface ICRMRepository
    {
        /// <summary>
        /// Delete entitity.
        /// </summary>
        /// <typeparam name="TEntity">Type of model.</typeparam>
        /// <param name="entityId">Id to delete.</param>
        void Delete<TEntity>(int entityId)
            where TEntity : class;

        /// <summary>
        /// GetEntity tuple by ID.
        /// </summary>
        /// <typeparam name="TEntity">TEntity">Type of model.</typeparam>
        /// <param name="entityID">Inique id.</param>
        /// <returns>Tuple of type.</returns>
        TEntity? GetEntityByID<TEntity>(int entityID)
            where TEntity : class;

        /// <summary>
        /// Get IQueryable from entity.
        /// </summary>
        /// <typeparam name="TEntity">TEntity">Type of model.</typeparam>
        /// <returns>IQueryble to select from entity.</returns>
        IQueryable<TEntity> GetTEntity<TEntity>()
            where TEntity : class;

        /// <summary>
        /// Insert an entity.
        /// </summary>
        /// <typeparam name="TEntity">TEntity">Type of model.</typeparam>
        /// <param name="entity">The Entity Object to add.</param>
        void InsertEntity<TEntity>(TEntity entity)
            where TEntity : class;

        /// <summary>
        /// Save last changes.
        /// </summary>
        /// <returns>Number of entries.</returns>
        int SaveChanges();

        /// <summary>
        /// Save last changes async.
        /// </summary>
        /// <returns>Number of entries.</returns>
        Task<int> SaveChangesAsync();

        /// <summary>
        /// Update table Tupel.
        /// </summary>
        /// <typeparam name="TEntity">Database Entity.</typeparam>
        /// <param name="entity">New table tupel.</param>
        void Update<TEntity>(TEntity entity)
            where TEntity : class;

        /// <inheritdoc/>
        void Dispose();
    }
}