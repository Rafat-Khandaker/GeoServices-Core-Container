using GeoServices_Core_Commons.Entity.Contracts;
using GeoServices_Core_Commons.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoServices_Core_Commons.Entity
{
    public class AppDatabase : DbContext, IAppDatabase
    {
        public DbSet<PerformanceLog> PerformanceLogs { get; set; }

        public string ConnectionString { get; set; }

        public AppDatabase(DbContextOptions<AppDatabase> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public AppDatabase DetachEntities()
        {
            var trackedEntities = ChangeTracker.Entries()
                                    .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified || e.State == EntityState.Unchanged)
                                    .ToList();

            foreach (var entry in trackedEntities)
            {

                entry.State = EntityState.Detached;
            }

            ChangeTracker.Clear();

            return this;
        }

        public void Attach_And_Save_Entities(List<PerformanceLog> newEntities)
        {
            var rowCount = PerformanceLogs.Max(e => e.Id);
            foreach (var entity in newEntities)
            {
                var existingEntity = ChangeTracker.Entries<PerformanceLog>()
                                         .FirstOrDefault(e => e.Entity.Id == entity.Id);

                if (existingEntity != null)
                {
                    entity.Id = ++rowCount;
                    Entry(existingEntity.Entity).CurrentValues.SetValues(entity);
                }
                else PerformanceLogs.Attach(entity);

                try
                {
                    SaveChanges();
                }
                catch (Exception ex)
                {
                    continue;
                }
            }

        }
    }
}
