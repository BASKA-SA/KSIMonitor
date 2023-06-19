using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace KSIMonitor.Data {
    // from Microsoft.EntityFrameworkCore.DBContext
    //  Microsoft.EntityFrameworkCore v6.0.16
    public interface IDBContext : IDisposable, IAsyncDisposable, IInfrastructure<IServiceProvider>, IResettableService {
        // Events
        public event EventHandler<SavingChangesEventArgs> SavingChanges;
        public event EventHandler<SavedChangesEventArgs> SavedChanges;
        public event EventHandler<SaveChangesFailedEventArgs> SaveChangesFailed;

        // Properties
        public DatabaseFacade Database { get; }
        public ChangeTracker ChangeTracker { get; }
        public Microsoft.EntityFrameworkCore.Metadata.IModel Model { get; }
        public DbContextId ContextId { get; }

        // Void Methods
        public void AddRange(params object[] entities);
        public void AddRange(IEnumerable<object> entities);
        public Task AddRangeAsync(params object[] entities);
        public Task AddRangeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default(CancellationToken));
        public void AttachRange(params object[] entities);
        public void AttachRange(IEnumerable<object> entities);
        public void UpdateRange(params object[] entities);
        public void UpdateRange(IEnumerable<object> entities);
        public void RemoveRange(params object[] entities);
        public void RemoveRange(IEnumerable<object> entities);

        // Other Methods
        public DbSet<TEntity> Set<TEntity>() where TEntity : class;
        public DbSet<TEntity> Set<TEntity>(string name) where TEntity : class;
        public EntityEntry Entry(object entity);
        public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        public EntityEntry Add(object entity);
        public EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;
        public ValueTask<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = default(CancellationToken));
        public ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class;
        public EntityEntry Attach(object entity);
        public EntityEntry<TEntity> Attach<TEntity>(TEntity entity) where TEntity : class;
        public EntityEntry Update(object entity);
        public EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;
        public EntityEntry Remove(object entity);
        public EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;
        public object Find(Type entityType, params object[] keyValues);
        public TEntity Find<TEntity>(params object[] keyValues) where TEntity : class;
        public ValueTask<object> FindAsync(Type entityType, params object[] keyValues);
        public ValueTask<object> FindAsync(Type entityType, object[] keyValues, CancellationToken cancellationToken);
        public ValueTask<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : class;
        public ValueTask<TEntity> FindAsync<TEntity>(object[] keyValues, CancellationToken cancellationToken) where TEntity : class;
        public int SaveChanges();
        public int SaveChanges(bool acceptAllChangesOnSuccess);
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        public Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
        public System.Linq.IQueryable<TResult> FromExpression<TResult>(System.Linq.Expressions.Expression<Func<System.Linq.IQueryable<TResult>>> expression);

        protected internal void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
        protected internal void ConfigureConventions(ModelConfigurationBuilder configurationBuilder) { }
        protected internal void OnModelCreating(ModelBuilder modelBuilder) { }
        abstract IServiceProvider IInfrastructure<IServiceProvider>.Instance { get; }
    }
}
